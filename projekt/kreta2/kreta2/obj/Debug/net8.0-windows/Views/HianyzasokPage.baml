   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      
 kreta2%   KretaClone.Views.HianyzasokPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      6sys&clr-namespace:System;assembly=mscorlib     5        N� Title$  Hiányzások��5      .��5      �� $��20q�6   
�������.+�5   
   �� $!��Új hiányzás hozzáadása��6   $
��Bold"�62   $��18(�6D   $��0,0,0,10q�6R   �� 5
   
    �� Orientation$ 
Horizontal=�6   $��0,0,0,10q�6.   .+�5      �� -   5         ��Name$ TantargyTextBox��5      $	��120��6/   $��0,0,10,0q�6;   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ DatumPicker��5      
 �� Now   SelectedDate# Z 6.   $	��140��6Y   $��0,0,10,0q�6e   �� 5      -   5        $ MegjegyzesTextBox��5      $	��150��61   $��0,0,10,0q�6=   �� 5      -   5        $��Hozzáadás��5      6)   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ HianyzasokDataGrid��5         AutoGenerateColumns$ False��6/      CanUserAddRows$ False��6K   $	��300��6b   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 	Tantárgy��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *
Tantargy+6T     5      $
 Dátum��6%   $	 150 6^    64   �� *Datum+ �� StringFormat$ d��6^     5      $
 Megjegyzés��6%   $ * 6X    69   �� *
Megjegyzes+6X   5      5      5      