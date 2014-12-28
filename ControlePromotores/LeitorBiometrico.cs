using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NITGEN.SDK.NBioBSP;

namespace ControlePromotores
{
    class LeitorBiometrico : Enumerable
    {
        //Inicializar o leitor   
        m_


            int i;
            uint nNumDevice;
            short[] nDeviceID;
            uint ret = m_NBioAPI.EnumerateDevice(out nNumDevice, out nDeviceID);
            if (ret == m_NBioAPI.Error.NONE)
            {
            comboDevice.Items.Add("Auto_Detect");
            for (i = 0; i < nNumDevice; i++)
            {
            switch (nDeviceID[i])
            {
            case NBioAPI.Type.DEVICE_NAME.FDU04:
            comboDevice.Items.Add("FDU04");
            break;
            case NBioAPI.Type.DEVICE_NAME.FDU14:
            comboDevice.Items.Add("FDU14");
            break;
            }
          }
        }
    }
}
