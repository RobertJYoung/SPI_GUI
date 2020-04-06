/*
 Goals:
 1. W/R a single byte
 2. Read an entire block of bytes from hex zero to 127
 3. Read an entire block and convert this to readable voltage value 
    (use a forms built-in table element)

*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPSSELight;
using FTD2XX_NET;

namespace SPI_GUI_v2
{
    public partial class Form1 : Form
    {
        // Constants
        public const string DEFAULT_INPUT_TEXT = "Enter ASCII text to transmit here";
        public const string DEFAULT_OUTPUT_TEXT = "Output of transmission will appear here";
        public const string CONNECTED = "Status : Connected";
        public const string DISCONNECTED = "Status : Disconnected";
        public const int freqUbound = 30000000; //Hz
        public const int freqLbound = 457; //Hz

        // Vars
        MpsseDevice mpsse;
        SpiDevice spi;
        FTDI.FT_DEVICE_INFO_NODE[] ftdiDeviceList;
        public string selectedSerialNumber = "";
        public bool inTextClicked = false;
        public bool outTextClicked = false;
        public bool connected = false;
        public int frequency = 100000; // value in Hz

        private ushort calculateDivisor(int frequency)
        {
            ushort div = (ushort)(((60 * 1000000) / (2 * frequency)) - 1);
            return div;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!inTextClicked)
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                inTextClicked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        public static byte[] ConvertHexStringToByteArray(string hexString)
        {
            if (hexString.Length % 2 != 0)
            {
                throw new ArgumentException(String.Format(System.Globalization.CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", hexString));
            }

            byte[] data = new byte[hexString.Length / 2];
            for (int index = 0; index < data.Length; index++)
            {
                string byteValue = hexString.Substring(index * 2, 2);
                data[index] = byte.Parse(byteValue, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture);
            }
            return data;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!connected)
                {
                    otextBox.Text = ("Cannot transmit data until connected! Connect first before transmitting!");
                }
                else
                {
                    List<String> errors = new List<string>();

                    // Check to see if valid input length (even)
                    if(itextBox.Text.Length % 2 != 0)
                    {
                        Console.WriteLine("Input was not a valid hex sequence of even length");
                        throw new Exception();
                    }

                    byte[] tdata = ConvertHexStringToByteArray(itextBox.Text);
                    //byte[] tdata = Encoding.UTF8.GetBytes(temp);

                    byte[] rdata = spi.readWrite(tdata);

                    string rdataString = BitConverter.ToString(rdata).Replace("-", "");
                    //string rdataString = Encoding.UTF8.GetString(rdata);
                    table.Rows.Clear();

                    for (int i = 0; i < rdata.Length; i++)
                    {
                        if(tdata[i] != rdata[i])
                        {
                            errors.Add("byte[" + i + "] : " + "sent = " + tdata[i] + ", received = " + rdata[i] + Environment.NewLine);
                        }
                        table.Rows.Add(i, rdataString.Substring(i*2, 2), rdata[i], "X");
                    }

                    otextBox.Text = rdataString;

                    if (errors.Count > 0)
                    {
                        otextBox.Text += Environment.NewLine + "Errors: " + Environment.NewLine;
                        for (int i = 0; i < errors.Count; i++)
                            otextBox.Text += errors[i];
                    }
                    else
                    {
                        otextBox.AppendText(Environment.NewLine + Environment.NewLine + "*No errors detected*" + Environment.NewLine);
                    }
                }
            }
            catch (System.FormatException sfe)
            {
                Console.WriteLine("Exception thrown: 'System.FormatException' in mscorlib.dll: input did not follow approriate format");
                otextBox.Text = "Exception thrown: 'System.FormatException' in mscorlib.dll: input did not follow approriate format";
            }
            catch (Exception ex)
            {
                Console.Write("Exception occured!...Disconnecting");
                status_label.Text = DISCONNECTED;
                connectButton.BackColor = Color.Red;
                otextBox.Text = "Failed to connect!";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                mpsse = new FT232H(selectedSerialNumber);
                spi = new SpiDevice(mpsse);
                mpsse.Loopback = true;
                status_label.Text = CONNECTED;
                connectButton.BackColor = Color.Lime;
                otextBox.Text = "Succesful connection!" + Environment.NewLine + "Frequency = 100kHz"; 
                otextBox.Text = "Succesful connection!" + Environment.NewLine + "Frequency = 100kHz"; // Repetition needed to make this appear??
                connected = true;

            }
            catch(Exception ex)
            {
                Console.Write("Exception occured!...Disconnecting");
                status_label.Text = DISCONNECTED;
                connectButton.BackColor = Color.Red;
                otextBox.Text = "Failed to connect!";
                connected = false;
            }
        }

        private void outLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSerialNumber = (string) devices.SelectedItem;
            devInfo.Text = ftdiDeviceList[devices.SelectedIndex].Description + Environment.NewLine;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                FTDI ftdi = new FTDI();
                UInt32 ftdiDeviceCount = 0;
                FTDI.FT_STATUS ftStatus = FTDI.FT_STATUS.FT_OTHER_ERROR;

                // Determine the number of FTDI devices connected to the machine
                ftStatus = ftdi.GetNumberOfDevices(ref ftdiDeviceCount);
                // Check status
                if (ftStatus != FTDI.FT_STATUS.FT_OK)
                    throw new Exception(string.Format("Error after GetNumberOfDevices(), ftStatus: {0}", ftStatus));

                if (ftdiDeviceCount == 0)
                    throw new Exception("No FTDI device found");

                // Allocate storage for device info list
                ftdiDeviceList = new FTDI.FT_DEVICE_INFO_NODE[ftdiDeviceCount];

                // Populate our device list
                ftStatus = ftdi.GetDeviceList(ftdiDeviceList);

                // Print out a selectable tag in the Devices selection box
                foreach (FTDI.FT_DEVICE_INFO_NODE dev in ftdiDeviceList)
                {
                    devices.Items.Add(dev.SerialNumber);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void freqbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void setFreq_button_Click(object sender, EventArgs e)
        {
            if (mpsse == null)
            {
                otextBox.Text = "Must connect device before setting frequency!";
            }
            else
            {
                if (frequency > freqUbound || frequency < freqLbound)
                {
                    Console.WriteLine("Frequency is outside of valid range [457Hz, 60MHz]");
                    otextBox.Text = "Frequency is outside of valid range [457Hz, 60MHz]";
                }
                else
                {
                    frequency = Int32.Parse(freqbox.Text); // NOTE: value is parsed as a signed integer
                    mpsse.ClkDivisor = calculateDivisor(frequency);
                    Console.WriteLine("Clk div was changed to " + mpsse.ClkDivisor);
                    otextBox.Text = "Device frequency set to : " + frequency + " Hz";
                }
            }
        }
    }
}
