using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class joystick : MonoBehaviour
{
    SerialPort sp = new SerialPort("COM8", 9600);
    int val = 0;
    int acc = 5;


    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;

    }

    void Update()
    {
        if (sp.IsOpen)
        {
            try
            {
                sp.Write("s");
                val = sp.ReadByte();
                Debug.Log(val);
                if ((val & 0x01) == 0x01)
                {
                    transform.Translate(Vector3.back * Time.deltaTime * acc);
                }
                else if ((val & 0x02) == 0x02)
                {
                    transform.Translate(Vector3.forward * Time.deltaTime * acc);
                }
                if ((val & 0x04) == 0x04)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * acc);
                }
                else if ((val & 0x08) == 0x08)
                {
                    transform.Translate(Vector3.right * Time.deltaTime * acc);
                }
            }
            catch (System.Exception) { }
        }

    }
}