#region Namespaces
using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
#endregion

namespace APIViet.Ribbon
{
    public class SplitButton
    {
        public SplitButton() {}

        //PushButton
        public void AddSplitButton(RibbonPanel panel, string btnName, string assembyName, string className, BitmapImage image, string btnTooltip)
        {
            //Set the information about the command we will be assigning to the button
            PushButtonData btnData = new PushButtonData("btn" + btnName, btnName + Environment.NewLine, assembyName, className);

            //Add buton to panel
            PushButton btn1 = panel.AddItem(btnData) as PushButton;
            btn1.ToolTip = btnTooltip;
            ContextualHelp help = new ContextualHelp(ContextualHelpType.Url, "http://www.autodesk.com");
            btn1.SetContextualHelp(help);
            IconControl img = new IconControl();
            if (image != null)
            {
                btn1.LargeImage = image;
            }
        }
    }
}
