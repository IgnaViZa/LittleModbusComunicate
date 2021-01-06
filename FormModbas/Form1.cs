using EasyModbus;
using System;
using System.Windows.Forms;

namespace FormModbas
{
    public partial class Form1 : Form
    {
        ModbusClient modbusClient;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                modbusClient = new ModbusClient(txt_ip_modbus.Text, 502);    //Ip-Address and Port of Modbus-TCP-Server
                modbusClient.Connect();

                modbusClient.WriteMultipleCoils(0, new bool[] { true, false, true });//Write Coils starting with Address 0
                bool[] readCoils = modbusClient.ReadCoils(0, 10);//Read 10 Coils from Server, starting with address 10
                int[] readHoldingRegisters = modbusClient.ReadHoldingRegisters(0, 10);//Read 10 Holding Registers from Server, starting with Address 1

                // Console Output
                for (int i = 0; i < readCoils.Length; i++)
                    Console.WriteLine("Value of Coil " + (i + 1) + " " + readCoils[i].ToString());

                for (int i = 0; i < readHoldingRegisters.Length; i++)
                    Console.WriteLine("Value of HoldingRegister " + (i + 1) + " " + readHoldingRegisters[i].ToString());
                lbl_connected.Text = "Connected!!!";
                lbl_connect_status.Text = "Connect";
                tmr_modbus.Enabled = true;
            }
            catch (Exception ex)
            {
                lbl_connected.Text = ex.ToString();
            }
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            modbusClient.Disconnect();
            lbl_connected.Text = "Offline";
            lbl_connect_status.Text = "Disconnected";
            tmr_modbus.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tmr_modbus.Enabled = false;

            modbusClient.WriteMultipleCoils(0, new bool[] { true, false, true });    //Write Coils starting with Address 0
            //modbusClient.WriteMultipleRegisters(0,new int[] {30});
            bool[] readCoils = modbusClient.ReadCoils(0, 10);                        //Read 10 Coils from Server, starting with address 0
            int[] readHoldingRegisters = modbusClient.ReadHoldingRegisters(0, 10);    //Read 10 Holding Registers from Server, starting with Address 1

            progressBar1.Value = readHoldingRegisters[0];
            //Checking the write senteces
            cb_col_1.Checked = readCoils[0];
            cb_col_2.Checked = readCoils[1];

            cb_col_3.Checked = (modbusClient.ReadDiscreteInputs(0,1)[0]); //Dates from DigitalInputs
            lbl_connect_status.Text = modbusClient.ReadInputRegisters(0, 1)[0].ToString();

            tmr_modbus.Enabled = true;
        }


        private void cb_col_4_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_col_4.Checked)
            {
                modbusClient.WriteSingleCoil(3, true);
            }
            else
            {
                modbusClient.WriteSingleCoil(3, false);
            }
        }

        private void cb_col_5_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_col_5.Checked)
            {
                modbusClient.WriteSingleCoil(4, true);
            }
            else
            {
                modbusClient.WriteSingleCoil(4, false);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            modbusClient.WriteSingleRegister(1, trackBar1.Value);
        }
    }
}
