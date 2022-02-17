namespace MyAlarm;

partial class MyAlarmForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(600, 400);
        this.Text = "MyAlarm";

        TableLayoutPanel mainTlP= new System.Windows.Forms.TableLayoutPanel();
        mainTlP.RowCount= 2;
        mainTlP.ColumnCount=2;
        mainTlP.Size= new System.Drawing.Size(600, 400);

        TableLayoutPanel hourTLP= new TableLayoutPanel();
        hourTLP.RowCount=1;
        hourTLP.ColumnCount=2;
        hourTLP.Size= new System.Drawing.Size(300, 250);
        TextBox hourTB= new TextBox();
        hourTB.Size= new System.Drawing.Size(100, 100);
        hourTB.TextAlign= HorizontalAlignment.Center;
        hourTB.Anchor= AnchorStyles.Left;

        TextBox minuteTB= new TextBox();
        minuteTB.Size= new System.Drawing.Size(100, 100);
        minuteTB.TextAlign= HorizontalAlignment.Center;
        minuteTB.Anchor= AnchorStyles.Left;

        hourTLP.Controls.Add(hourTB);
        hourTLP.Controls.Add(minuteTB);
        mainTlP.Controls.Add(hourTLP);
        this.Controls.Add(mainTlP);
    }

    #endregion
}
