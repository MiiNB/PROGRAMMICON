﻿// Fig. 14.40: KeyDemoForm.cs
// Displaying information about the key the user pressed.
using System;
using System.Windows.Forms;

namespace KeyDemo
{
   // Form to display key information when key is pressed
   public partial class KeyDemo : Form
   {
      // default constructor
      public KeyDemo()
      {
         InitializeComponent();
      } // end constructor

      // display the character pressed using KeyChar
      private void KeyDemoForm_KeyPress( 
         object sender, KeyPressEventArgs e )
      {
         charLabel.Text = "Key pressed: " + e.KeyChar;
      } // end method KeyDemo_KeyPress

      // display modifier keys, key code, key data and key value
      private void KeyDemoForm_KeyDown( object sender, KeyEventArgs e )
      {
         keyInfoLabel.Text =
            "Alt: " + ( e.Alt ? "Yes" : "No" ) + '\n' +
            "Shift: " + ( e.Shift ? "Yes" : "No" ) + '\n' +
            "Ctrl: " + ( e.Control ? "Yes" : "No" ) + '\n' +
            "KeyCode: " + e.KeyCode + '\n' +
            "KeyData: " + e.KeyData + '\n' +
            "KeyValue: " + e.KeyValue;
      } // end method KeyDemo_KeyDown

      // clear Labels when key released
      private void KeyDemoForm_KeyUp( object sender, KeyEventArgs e )
      {
         charLabel.Text = "";
         keyInfoLabel.Text = "";
      } // end method KeyDemo_KeyUp
   } // end class KeyDemoForm
} // end namespace KeyDemo

/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/