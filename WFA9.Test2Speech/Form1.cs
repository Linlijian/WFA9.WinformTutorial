﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;


namespace WFA9.Test2Speech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SpeechSynthesizer sp;
        private void Form1_Load(object sender, EventArgs e)
        {
            sp = new SpeechSynthesizer();

            foreach (var item in sp.GetInstalledVoices())
            {
                comboBox1.Items.Add(item.VoiceInfo.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sp.SelectVoice(comboBox1.SelectedItem.ToString());

            sp.Speak(textBox1.Text);
        }
    }
}

/*
Windows Registry Editor Version 5.00

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Speech\Voices\Tokens\TTS_THAI]
@= "Microsoft Pattara - Thai (Thailand)"
"41E" = "Microsoft Pattara - Thai (Thailand)"
"CLSID" = "{179F3D56-1B0B-42B2-A962-59B7EF59FE1B}"
"LangDataPath" = hex(2):25,00,77,00,69,00,6e,00,64,00,69,00,72,00,25,00,5c,00,53,\
  00,70,00,65,00,65,00,63,00,68,00,5f,00,4f,00,6e,00,65,00,43,00,6f,00,72,00,\
  65,00,5c,00,45,00,6e,00,67,00,69,00,6e,00,65,00,73,00,5c,00,54,00,54,00,53,\
  00,5c,00,74,00,68,00,2d,00,54,00,48,00,5c,00,4d,00,53,00,54,00,54,00,53,00,\
  4c,00,6f,00,63,00,54,00,68,00,54,00,48,00,2e,00,64,00,61,00,74,00,00,00
"VoicePath" = hex(2):25,00,77,00,69,00,6e,00,64,00,69,00,72,00,25,00,5c,00,53,00,\
  70,00,65,00,65,00,63,00,68,00,5f,00,4f,00,6e,00,65,00,43,00,6f,00,72,00,65,\
  00,5c,00,45,00,6e,00,67,00,69,00,6e,00,65,00,73,00,5c,00,54,00,54,00,53,00,\
  5c,00,74,00,68,00,2d,00,54,00,48,00,5c,00,4d,00,31,00,30,00,35,00,34,00,50,\
  00,61,00,74,00,74,00,61,00,72,00,61,00,00,00

[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Speech\Voices\Tokens\TTS_THAI\Attributes]
"Age" = "Adult"
"DataVersion" = "11.0.2016.1016"
"Gender" = "Male"
"Language" = "41E"
"Name" = "Microsoft Pattara"
"SayAsSupport" = "spell=NativeSupported; alphanumeric=NativeSupported"
"SharedPronunciation" = ""
"Vendor" = "Microsoft"
"Version" = "11.0"
*/
