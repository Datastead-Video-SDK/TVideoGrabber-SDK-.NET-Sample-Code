﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
    public partial class Audio : Form
    {
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
		private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkRenderAudioDevice = new System.Windows.Forms.CheckBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStopAudio = new System.Windows.Forms.Button();
            this.btnStartWMVRecording = new System.Windows.Forms.Button();
            this.btnSartMP3Recording = new System.Windows.Forms.Button();
            this.btnStartWavRecording = new System.Windows.Forms.Button();
            this.btnStartAudioRendering = new System.Windows.Forms.Button();
            this.chkUseAudioOfVideoCaptureDevice = new System.Windows.Forms.CheckBox();
            this.pnlVUMeterRight = new System.Windows.Forms.Panel();
            this.pnlVUMeterLeft = new System.Windows.Forms.Panel();
            this.grbVuMeters = new System.Windows.Forms.GroupBox();
            this.rdgVUBargraph = new System.Windows.Forms.RadioButton();
            this.rdgVUAnalog = new System.Windows.Forms.RadioButton();
            this.rdgVUDisabled = new System.Windows.Forms.RadioButton();
            this.grbAudioRendering = new System.Windows.Forms.GroupBox();
            this.cboAudioRenderers = new System.Windows.Forms.ComboBox();
            this.tbrAudioVolume = new System.Windows.Forms.TrackBar();
            this.tbrAudioBalance = new System.Windows.Forms.TrackBar();
            this.chkMuteAudioRendering = new System.Windows.Forms.CheckBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.grbAudioCaptureDevice = new System.Windows.Forms.GroupBox();
            this.btnAudioDeviceDialog = new System.Windows.Forms.Button();
            this.tbrAudioInputLevel = new System.Windows.Forms.TrackBar();
            this.tbrAudioInputBalance = new System.Windows.Forms.TrackBar();
            this.cboAudioDevices = new System.Windows.Forms.ComboBox();
            this.cboAudioInputs = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.btnBargraphOverlay = new System.Windows.Forms.Button();
            this.grbAudioSource = new System.Windows.Forms.GroupBox();
            this.rdgAudioSourceDefaultSpeakerRecording = new System.Windows.Forms.RadioButton();
            this.rdgAudioSourceSpeakerOutput = new System.Windows.Forms.RadioButton();
            this.rdgAudioSourceExternal = new System.Windows.Forms.RadioButton();
            this.rdgAudioSourceDefault = new System.Windows.Forms.RadioButton();
            this.GroupBox1.SuspendLayout();
            this.grbVuMeters.SuspendLayout();
            this.grbAudioRendering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrAudioVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrAudioBalance)).BeginInit();
            this.grbAudioCaptureDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrAudioInputLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrAudioInputBalance)).BeginInit();
            this.grbAudioSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkRenderAudioDevice
            // 
            this.chkRenderAudioDevice.AutoSize = true;
            this.chkRenderAudioDevice.BackColor = System.Drawing.SystemColors.Control;
            this.chkRenderAudioDevice.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkRenderAudioDevice.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkRenderAudioDevice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkRenderAudioDevice.Location = new System.Drawing.Point(177, 0);
            this.chkRenderAudioDevice.Name = "chkRenderAudioDevice";
            this.chkRenderAudioDevice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkRenderAudioDevice.Size = new System.Drawing.Size(215, 20);
            this.chkRenderAudioDevice.TabIndex = 26;
            this.chkRenderAudioDevice.Text = "AUDIO DEVICE RENDERING";
            this.chkRenderAudioDevice.UseVisualStyleBackColor = false;
            this.chkRenderAudioDevice.CheckedChanged += new System.EventHandler(this.chkRenderAudioDevice_CheckedChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnStopAudio);
            this.GroupBox1.Controls.Add(this.btnStartWMVRecording);
            this.GroupBox1.Controls.Add(this.btnSartMP3Recording);
            this.GroupBox1.Controls.Add(this.btnStartWavRecording);
            this.GroupBox1.Controls.Add(this.btnStartAudioRendering);
            this.GroupBox1.Controls.Add(this.chkUseAudioOfVideoCaptureDevice);
            this.GroupBox1.Location = new System.Drawing.Point(464, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(809, 76);
            this.GroupBox1.TabIndex = 25;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "AUDIO rendering / recording / streaming ONLY  (you can activate the streaming in " +
    "the \"network streaming\" tab)";
            // 
            // btnStopAudio
            // 
            this.btnStopAudio.Location = new System.Drawing.Point(490, 28);
            this.btnStopAudio.Name = "btnStopAudio";
            this.btnStopAudio.Size = new System.Drawing.Size(70, 36);
            this.btnStopAudio.TabIndex = 4;
            this.btnStopAudio.Text = "stop";
            this.btnStopAudio.Click += new System.EventHandler(this.btnStopAudio_Click);
            // 
            // btnStartWMVRecording
            // 
            this.btnStartWMVRecording.Location = new System.Drawing.Point(370, 28);
            this.btnStartWMVRecording.Name = "btnStartWMVRecording";
            this.btnStartWMVRecording.Size = new System.Drawing.Size(112, 36);
            this.btnStartWMVRecording.TabIndex = 3;
            this.btnStartWMVRecording.Text = "record WMV";
            this.btnStartWMVRecording.Click += new System.EventHandler(this.btnStartWMVRecording_Click);
            // 
            // btnSartMP3Recording
            // 
            this.btnSartMP3Recording.Location = new System.Drawing.Point(260, 28);
            this.btnSartMP3Recording.Name = "btnSartMP3Recording";
            this.btnSartMP3Recording.Size = new System.Drawing.Size(102, 36);
            this.btnSartMP3Recording.TabIndex = 2;
            this.btnSartMP3Recording.Text = "record MP3";
            this.btnSartMP3Recording.Click += new System.EventHandler(this.btnSartMP3Recording_Click);
            // 
            // btnStartWavRecording
            // 
            this.btnStartWavRecording.Location = new System.Drawing.Point(140, 28);
            this.btnStartWavRecording.Name = "btnStartWavRecording";
            this.btnStartWavRecording.Size = new System.Drawing.Size(112, 36);
            this.btnStartWavRecording.TabIndex = 1;
            this.btnStartWavRecording.Text = "record WAV";
            this.btnStartWavRecording.Click += new System.EventHandler(this.btnStartWavRecording_Click);
            // 
            // btnStartAudioRendering
            // 
            this.btnStartAudioRendering.Location = new System.Drawing.Point(8, 28);
            this.btnStartAudioRendering.Name = "btnStartAudioRendering";
            this.btnStartAudioRendering.Size = new System.Drawing.Size(124, 36);
            this.btnStartAudioRendering.TabIndex = 0;
            this.btnStartAudioRendering.Text = "start rendering";
            this.btnStartAudioRendering.Click += new System.EventHandler(this.btnStartAudioRendering_Click);
            // 
            // chkUseAudioOfVideoCaptureDevice
            // 
            this.chkUseAudioOfVideoCaptureDevice.Location = new System.Drawing.Point(568, 19);
            this.chkUseAudioOfVideoCaptureDevice.Name = "chkUseAudioOfVideoCaptureDevice";
            this.chkUseAudioOfVideoCaptureDevice.Size = new System.Drawing.Size(231, 53);
            this.chkUseAudioOfVideoCaptureDevice.TabIndex = 5;
            this.chkUseAudioOfVideoCaptureDevice.Text = "use the audio out of the video capture device, if any";
            this.chkUseAudioOfVideoCaptureDevice.CheckedChanged += new System.EventHandler(this.chkUseAudioOfVideoCaptureDevice_CheckedChanged);
            // 
            // pnlVUMeterRight
            // 
            this.pnlVUMeterRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlVUMeterRight.Location = new System.Drawing.Point(637, 147);
            this.pnlVUMeterRight.Name = "pnlVUMeterRight";
            this.pnlVUMeterRight.Size = new System.Drawing.Size(169, 124);
            this.pnlVUMeterRight.TabIndex = 24;
            // 
            // pnlVUMeterLeft
            // 
            this.pnlVUMeterLeft.AccessibleName = "";
            this.pnlVUMeterLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlVUMeterLeft.Location = new System.Drawing.Point(457, 147);
            this.pnlVUMeterLeft.Name = "pnlVUMeterLeft";
            this.pnlVUMeterLeft.Size = new System.Drawing.Size(171, 124);
            this.pnlVUMeterLeft.TabIndex = 23;
            // 
            // grbVuMeters
            // 
            this.grbVuMeters.Controls.Add(this.rdgVUBargraph);
            this.grbVuMeters.Controls.Add(this.rdgVUAnalog);
            this.grbVuMeters.Controls.Add(this.rdgVUDisabled);
            this.grbVuMeters.Location = new System.Drawing.Point(463, 83);
            this.grbVuMeters.Name = "grbVuMeters";
            this.grbVuMeters.Size = new System.Drawing.Size(286, 54);
            this.grbVuMeters.TabIndex = 22;
            this.grbVuMeters.TabStop = false;
            this.grbVuMeters.Text = "VU-Meters";
            // 
            // rdgVUBargraph
            // 
            this.rdgVUBargraph.Location = new System.Drawing.Point(194, 20);
            this.rdgVUBargraph.Name = "rdgVUBargraph";
            this.rdgVUBargraph.Size = new System.Drawing.Size(107, 28);
            this.rdgVUBargraph.TabIndex = 2;
            this.rdgVUBargraph.Tag = "2";
            this.rdgVUBargraph.Text = "bargraph";
            this.rdgVUBargraph.CheckedChanged += new System.EventHandler(this.rdgVUMeter_CheckedChanged);
            // 
            // rdgVUAnalog
            // 
            this.rdgVUAnalog.Location = new System.Drawing.Point(110, 20);
            this.rdgVUAnalog.Name = "rdgVUAnalog";
            this.rdgVUAnalog.Size = new System.Drawing.Size(91, 28);
            this.rdgVUAnalog.TabIndex = 1;
            this.rdgVUAnalog.Tag = "1";
            this.rdgVUAnalog.Text = "analog";
            this.rdgVUAnalog.CheckedChanged += new System.EventHandler(this.rdgVUMeter_CheckedChanged);
            // 
            // rdgVUDisabled
            // 
            this.rdgVUDisabled.Checked = true;
            this.rdgVUDisabled.Location = new System.Drawing.Point(16, 20);
            this.rdgVUDisabled.Name = "rdgVUDisabled";
            this.rdgVUDisabled.Size = new System.Drawing.Size(102, 28);
            this.rdgVUDisabled.TabIndex = 0;
            this.rdgVUDisabled.TabStop = true;
            this.rdgVUDisabled.Tag = "0";
            this.rdgVUDisabled.Text = "disabled";
            this.rdgVUDisabled.CheckedChanged += new System.EventHandler(this.rdgVUMeter_CheckedChanged);
            // 
            // grbAudioRendering
            // 
            this.grbAudioRendering.BackColor = System.Drawing.SystemColors.Control;
            this.grbAudioRendering.Controls.Add(this.cboAudioRenderers);
            this.grbAudioRendering.Controls.Add(this.tbrAudioVolume);
            this.grbAudioRendering.Controls.Add(this.tbrAudioBalance);
            this.grbAudioRendering.Controls.Add(this.chkMuteAudioRendering);
            this.grbAudioRendering.Controls.Add(this.Label5);
            this.grbAudioRendering.Controls.Add(this.Label6);
            this.grbAudioRendering.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbAudioRendering.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbAudioRendering.Location = new System.Drawing.Point(890, 73);
            this.grbAudioRendering.Name = "grbAudioRendering";
            this.grbAudioRendering.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbAudioRendering.Size = new System.Drawing.Size(383, 196);
            this.grbAudioRendering.TabIndex = 21;
            this.grbAudioRendering.TabStop = false;
            this.grbAudioRendering.Text = "audio rendering";
            // 
            // cboAudioRenderers
            // 
            this.cboAudioRenderers.Location = new System.Drawing.Point(91, 23);
            this.cboAudioRenderers.Name = "cboAudioRenderers";
            this.cboAudioRenderers.Size = new System.Drawing.Size(282, 24);
            this.cboAudioRenderers.TabIndex = 18;
            this.cboAudioRenderers.Text = "default (AudioRenderer = -1)";
            this.cboAudioRenderers.SelectedIndexChanged += new System.EventHandler(this.cboAudioRenderers_SelectedIndexChanged);
            // 
            // tbrAudioVolume
            // 
            this.tbrAudioVolume.AutoSize = false;
            this.tbrAudioVolume.Location = new System.Drawing.Point(16, 87);
            this.tbrAudioVolume.Maximum = 65535;
            this.tbrAudioVolume.Name = "tbrAudioVolume";
            this.tbrAudioVolume.Size = new System.Drawing.Size(357, 26);
            this.tbrAudioVolume.TabIndex = 17;
            this.tbrAudioVolume.TickFrequency = 7300;
            this.tbrAudioVolume.Scroll += new System.EventHandler(this.tbrAudioVolume_Scroll);
            // 
            // tbrAudioBalance
            // 
            this.tbrAudioBalance.AutoSize = false;
            this.tbrAudioBalance.Location = new System.Drawing.Point(16, 147);
            this.tbrAudioBalance.Maximum = 32767;
            this.tbrAudioBalance.Minimum = -32768;
            this.tbrAudioBalance.Name = "tbrAudioBalance";
            this.tbrAudioBalance.Size = new System.Drawing.Size(357, 26);
            this.tbrAudioBalance.TabIndex = 17;
            this.tbrAudioBalance.TickFrequency = 7300;
            this.tbrAudioBalance.Scroll += new System.EventHandler(this.tbrAudioBalance_Scroll);
            // 
            // chkMuteAudioRendering
            // 
            this.chkMuteAudioRendering.BackColor = System.Drawing.SystemColors.Control;
            this.chkMuteAudioRendering.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkMuteAudioRendering.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkMuteAudioRendering.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkMuteAudioRendering.Location = new System.Drawing.Point(16, 27);
            this.chkMuteAudioRendering.Name = "chkMuteAudioRendering";
            this.chkMuteAudioRendering.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkMuteAudioRendering.Size = new System.Drawing.Size(94, 26);
            this.chkMuteAudioRendering.TabIndex = 12;
            this.chkMuteAudioRendering.Text = "mute";
            this.chkMuteAudioRendering.UseVisualStyleBackColor = false;
            this.chkMuteAudioRendering.CheckedChanged += new System.EventHandler(this.chkMuteAudioRendering_CheckedChanged);
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.SystemColors.Control;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(22, 61);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(137, 27);
            this.Label5.TabIndex = 15;
            this.Label5.Text = "volume";
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.SystemColors.Control;
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(22, 123);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(137, 26);
            this.Label6.TabIndex = 14;
            this.Label6.Text = "balance";
            // 
            // grbAudioCaptureDevice
            // 
            this.grbAudioCaptureDevice.BackColor = System.Drawing.SystemColors.Control;
            this.grbAudioCaptureDevice.Controls.Add(this.btnAudioDeviceDialog);
            this.grbAudioCaptureDevice.Controls.Add(this.tbrAudioInputLevel);
            this.grbAudioCaptureDevice.Controls.Add(this.tbrAudioInputBalance);
            this.grbAudioCaptureDevice.Controls.Add(this.cboAudioDevices);
            this.grbAudioCaptureDevice.Controls.Add(this.cboAudioInputs);
            this.grbAudioCaptureDevice.Controls.Add(this.Label7);
            this.grbAudioCaptureDevice.Controls.Add(this.Label8);
            this.grbAudioCaptureDevice.Controls.Add(this.Label9);
            this.grbAudioCaptureDevice.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbAudioCaptureDevice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbAudioCaptureDevice.Location = new System.Drawing.Point(7, 128);
            this.grbAudioCaptureDevice.Name = "grbAudioCaptureDevice";
            this.grbAudioCaptureDevice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbAudioCaptureDevice.Size = new System.Drawing.Size(449, 143);
            this.grbAudioCaptureDevice.TabIndex = 20;
            this.grbAudioCaptureDevice.TabStop = false;
            this.grbAudioCaptureDevice.Text = "Audio capture device (if default selected above)";
            // 
            // btnAudioDeviceDialog
            // 
            this.btnAudioDeviceDialog.Location = new System.Drawing.Point(10, 104);
            this.btnAudioDeviceDialog.Name = "btnAudioDeviceDialog";
            this.btnAudioDeviceDialog.Size = new System.Drawing.Size(210, 31);
            this.btnAudioDeviceDialog.TabIndex = 33;
            this.btnAudioDeviceDialog.Text = "audio device dialog";
            this.btnAudioDeviceDialog.UseVisualStyleBackColor = true;
            this.btnAudioDeviceDialog.Click += new System.EventHandler(this.btnAudioDeviceDialog_Click);
            // 
            // tbrAudioInputLevel
            // 
            this.tbrAudioInputLevel.AutoSize = false;
            this.tbrAudioInputLevel.Location = new System.Drawing.Point(310, 60);
            this.tbrAudioInputLevel.Maximum = 65535;
            this.tbrAudioInputLevel.Name = "tbrAudioInputLevel";
            this.tbrAudioInputLevel.Size = new System.Drawing.Size(118, 28);
            this.tbrAudioInputLevel.TabIndex = 17;
            this.tbrAudioInputLevel.TickFrequency = 7300;
            this.tbrAudioInputLevel.Scroll += new System.EventHandler(this.tbrAudioInputLevel_Scroll);
            // 
            // tbrAudioInputBalance
            // 
            this.tbrAudioInputBalance.AutoSize = false;
            this.tbrAudioInputBalance.Location = new System.Drawing.Point(310, 97);
            this.tbrAudioInputBalance.Maximum = 32767;
            this.tbrAudioInputBalance.Minimum = -32768;
            this.tbrAudioInputBalance.Name = "tbrAudioInputBalance";
            this.tbrAudioInputBalance.Size = new System.Drawing.Size(118, 28);
            this.tbrAudioInputBalance.TabIndex = 17;
            this.tbrAudioInputBalance.TickFrequency = 7300;
            this.tbrAudioInputBalance.Scroll += new System.EventHandler(this.tbrAudioInputBalance_Scroll);
            // 
            // cboAudioDevices
            // 
            this.cboAudioDevices.BackColor = System.Drawing.SystemColors.Window;
            this.cboAudioDevices.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboAudioDevices.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboAudioDevices.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboAudioDevices.Location = new System.Drawing.Point(111, 20);
            this.cboAudioDevices.Name = "cboAudioDevices";
            this.cboAudioDevices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboAudioDevices.Size = new System.Drawing.Size(330, 24);
            this.cboAudioDevices.TabIndex = 4;
            this.cboAudioDevices.Text = "SELECT AN AUDIO CAPTURE DEVICE IN THIS LIST";
            this.cboAudioDevices.SelectedIndexChanged += new System.EventHandler(this.cboAudioDevices_SelectedIndexChanged);
            // 
            // cboAudioInputs
            // 
            this.cboAudioInputs.BackColor = System.Drawing.SystemColors.Window;
            this.cboAudioInputs.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboAudioInputs.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboAudioInputs.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboAudioInputs.Location = new System.Drawing.Point(7, 68);
            this.cboAudioInputs.Name = "cboAudioInputs";
            this.cboAudioInputs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboAudioInputs.Size = new System.Drawing.Size(179, 24);
            this.cboAudioInputs.TabIndex = 3;
            this.cboAudioInputs.SelectedIndexChanged += new System.EventHandler(this.cboAudioInputs_SelectedIndexChanged);
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.SystemColors.Control;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label7.Location = new System.Drawing.Point(7, 45);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(91, 26);
            this.Label7.TabIndex = 9;
            this.Label7.Text = "audio input";
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.SystemColors.Control;
            this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label8.Location = new System.Drawing.Point(245, 60);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(59, 28);
            this.Label8.TabIndex = 8;
            this.Label8.Text = "level";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.SystemColors.Control;
            this.Label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label9.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label9.Location = new System.Drawing.Point(227, 88);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label9.Size = new System.Drawing.Size(77, 28);
            this.Label9.TabIndex = 7;
            this.Label9.Text = "balance";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnBargraphOverlay
            // 
            this.btnBargraphOverlay.Location = new System.Drawing.Point(757, 84);
            this.btnBargraphOverlay.Name = "btnBargraphOverlay";
            this.btnBargraphOverlay.Size = new System.Drawing.Size(133, 59);
            this.btnBargraphOverlay.TabIndex = 30;
            this.btnBargraphOverlay.Text = "bargraph overlay";
            this.btnBargraphOverlay.UseVisualStyleBackColor = true;
            this.btnBargraphOverlay.Click += new System.EventHandler(this.btnBargraphOverlay_Click);
            // 
            // grbAudioSource
            // 
            this.grbAudioSource.Controls.Add(this.rdgAudioSourceDefaultSpeakerRecording);
            this.grbAudioSource.Controls.Add(this.rdgAudioSourceSpeakerOutput);
            this.grbAudioSource.Controls.Add(this.rdgAudioSourceExternal);
            this.grbAudioSource.Controls.Add(this.rdgAudioSourceDefault);
            this.grbAudioSource.Location = new System.Drawing.Point(7, 21);
            this.grbAudioSource.Name = "grbAudioSource";
            this.grbAudioSource.Size = new System.Drawing.Size(450, 99);
            this.grbAudioSource.TabIndex = 31;
            this.grbAudioSource.TabStop = false;
            this.grbAudioSource.Text = "audio source";
            // 
            // rdgAudioSourceDefaultSpeakerRecording
            // 
            this.rdgAudioSourceDefaultSpeakerRecording.AutoSize = true;
            this.rdgAudioSourceDefaultSpeakerRecording.Location = new System.Drawing.Point(111, 59);
            this.rdgAudioSourceDefaultSpeakerRecording.Name = "rdgAudioSourceDefaultSpeakerRecording";
            this.rdgAudioSourceDefaultSpeakerRecording.Size = new System.Drawing.Size(303, 24);
            this.rdgAudioSourceDefaultSpeakerRecording.TabIndex = 3;
            this.rdgAudioSourceDefaultSpeakerRecording.TabStop = true;
            this.rdgAudioSourceDefaultSpeakerRecording.Text = "default audio source + speaker recording";
            this.rdgAudioSourceDefaultSpeakerRecording.UseVisualStyleBackColor = true;
            this.rdgAudioSourceDefaultSpeakerRecording.CheckedChanged += new System.EventHandler(this.rdgAudioSourceDefaultSpeakerRecording_CheckedChanged);
            // 
            // rdgAudioSourceSpeakerOutput
            // 
            this.rdgAudioSourceSpeakerOutput.AutoSize = true;
            this.rdgAudioSourceSpeakerOutput.Location = new System.Drawing.Point(111, 28);
            this.rdgAudioSourceSpeakerOutput.Name = "rdgAudioSourceSpeakerOutput";
            this.rdgAudioSourceSpeakerOutput.Size = new System.Drawing.Size(129, 24);
            this.rdgAudioSourceSpeakerOutput.TabIndex = 2;
            this.rdgAudioSourceSpeakerOutput.TabStop = true;
            this.rdgAudioSourceSpeakerOutput.Text = "speaker output";
            this.rdgAudioSourceSpeakerOutput.UseVisualStyleBackColor = true;
            this.rdgAudioSourceSpeakerOutput.CheckedChanged += new System.EventHandler(this.rdgAudioSourceSpeakerOutput_CheckedChanged);
            // 
            // rdgAudioSourceExternal
            // 
            this.rdgAudioSourceExternal.AutoSize = true;
            this.rdgAudioSourceExternal.Location = new System.Drawing.Point(7, 59);
            this.rdgAudioSourceExternal.Name = "rdgAudioSourceExternal";
            this.rdgAudioSourceExternal.Size = new System.Drawing.Size(83, 24);
            this.rdgAudioSourceExternal.TabIndex = 1;
            this.rdgAudioSourceExternal.TabStop = true;
            this.rdgAudioSourceExternal.Text = "external";
            this.rdgAudioSourceExternal.UseVisualStyleBackColor = true;
            this.rdgAudioSourceExternal.CheckedChanged += new System.EventHandler(this.rdgAudioSourceExternal_CheckedChanged);
            // 
            // rdgAudioSourceDefault
            // 
            this.rdgAudioSourceDefault.AutoSize = true;
            this.rdgAudioSourceDefault.Checked = true;
            this.rdgAudioSourceDefault.Location = new System.Drawing.Point(7, 28);
            this.rdgAudioSourceDefault.Name = "rdgAudioSourceDefault";
            this.rdgAudioSourceDefault.Size = new System.Drawing.Size(77, 24);
            this.rdgAudioSourceDefault.TabIndex = 0;
            this.rdgAudioSourceDefault.TabStop = true;
            this.rdgAudioSourceDefault.Text = "default";
            this.rdgAudioSourceDefault.UseVisualStyleBackColor = true;
            this.rdgAudioSourceDefault.CheckedChanged += new System.EventHandler(this.rdgAudioSourceDefault_CheckedChanged);
            // 
            // Audio
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 20);
            this.ClientSize = new System.Drawing.Size(1299, 300);
            this.ControlBox = false;
            this.Controls.Add(this.grbAudioSource);
            this.Controls.Add(this.btnBargraphOverlay);
            this.Controls.Add(this.chkRenderAudioDevice);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.pnlVUMeterRight);
            this.Controls.Add(this.pnlVUMeterLeft);
            this.Controls.Add(this.grbVuMeters);
            this.Controls.Add(this.grbAudioRendering);
            this.Controls.Add(this.grbAudioCaptureDevice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Audio";
            this.ShowInTaskbar = false;
            this.VisibleChanged += new System.EventHandler(this.Audio_VisibleChanged);
            this.GroupBox1.ResumeLayout(false);
            this.grbVuMeters.ResumeLayout(false);
            this.grbAudioRendering.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbrAudioVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrAudioBalance)).EndInit();
            this.grbAudioCaptureDevice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbrAudioInputLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrAudioInputBalance)).EndInit();
            this.grbAudioSource.ResumeLayout(false);
            this.grbAudioSource.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolTip ToolTip1;
        private System.ComponentModel.IContainer components;

        private CheckBox chkRenderAudioDevice;
        private GroupBox GroupBox1;
        private Button btnStopAudio;
        private Button btnStartWMVRecording;
        private Button btnSartMP3Recording;
        private Button btnStartWavRecording;
        private Button btnStartAudioRendering;
        private CheckBox chkUseAudioOfVideoCaptureDevice;
        private Panel pnlVUMeterRight;
        private Panel pnlVUMeterLeft;
        private GroupBox grbVuMeters;
        private RadioButton rdgVUBargraph;
        private RadioButton rdgVUAnalog;
        private RadioButton rdgVUDisabled;
        private GroupBox grbAudioRendering;
        private ComboBox cboAudioRenderers;
        private TrackBar tbrAudioVolume;
        private TrackBar tbrAudioBalance;
        private CheckBox chkMuteAudioRendering;
        private Label Label5;
        private Label Label6;
        private GroupBox grbAudioCaptureDevice;
        private TrackBar tbrAudioInputLevel;
        private TrackBar tbrAudioInputBalance;
        internal ComboBox cboAudioDevices;
        internal ComboBox cboAudioInputs;
        private Label Label7;
        private Label Label8;
        private Label Label9;
        private Button btnBargraphOverlay;
        private GroupBox grbAudioSource;
        private RadioButton rdgAudioSourceExternal;
        private RadioButton rdgAudioSourceDefault;
        private RadioButton rdgAudioSourceSpeakerOutput;
        private RadioButton rdgAudioSourceDefaultSpeakerRecording;
        private Button btnAudioDeviceDialog;
    }
}

