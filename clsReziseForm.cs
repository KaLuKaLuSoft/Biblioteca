using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

public class clsResizeForm
{
    private float f_HeightRatio = new float();
    private float f_WidthRatio = new float();
    public void ResizeForm(Form ObjForm, int DesignerWidth, int DesignerHeight)
    {
        int i_StandardHeight = DesignerHeight;
        int i_StandardWidth = DesignerWidth;
        int i_PresentHeight = Screen.PrimaryScreen.Bounds.Height;
        int i_PresentWidth = Screen.PrimaryScreen.Bounds.Width;
        f_HeightRatio = ((float)(Convert.ToSingle(i_PresentHeight) / (double)Convert.ToSingle(i_StandardHeight)));
        f_WidthRatio = (float)(Convert.ToSingle(i_PresentWidth) / (double)Convert.ToSingle(i_StandardWidth));
        ObjForm.AutoScaleMode = AutoScaleMode.None;
        ObjForm.Scale(new SizeF(f_WidthRatio, f_HeightRatio));
        foreach (Control c in ObjForm.Controls)
        {
            if (c.HasChildren)
                ResizeControlStore(c);
            else
                c.Font = new Font(c.Font.FontFamily, c.Font.Size * f_HeightRatio, c.Font.Style, c.Font.Unit, (System.Convert.ToByte(0)));
        }
        ObjForm.Font = new Font(ObjForm.Font.FontFamily, ObjForm.Font.Size * f_HeightRatio, ObjForm.Font.Style, ObjForm.Font.Unit, (System.Convert.ToByte(0)));
    }
    private void ResizeControlStore(Control objCtl)
    {
        if (objCtl.HasChildren)
        {
            foreach (Control cChildren in objCtl.Controls)
            {
                if (cChildren.HasChildren)
                    ResizeControlStore(cChildren);
                else
                    cChildren.Font = new Font(cChildren.Font.FontFamily, cChildren.Font.Size * f_HeightRatio, cChildren.Font.Style, cChildren.Font.Unit, (System.Convert.ToByte(0)));
            }
            objCtl.Font = new Font(objCtl.Font.FontFamily, objCtl.Font.Size * f_HeightRatio, objCtl.Font.Style, objCtl.Font.Unit, (System.Convert.ToByte(0)));
        }
        else
            objCtl.Font = new Font(objCtl.Font.FontFamily, objCtl.Font.Size * f_HeightRatio, objCtl.Font.Style, objCtl.Font.Unit, (System.Convert.ToByte(0)));
    }
}
