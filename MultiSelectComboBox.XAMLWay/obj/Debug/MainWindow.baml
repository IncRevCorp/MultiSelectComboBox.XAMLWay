   M S B A M L   `   `   `  ����  MultiSelectComboBox.XAMLWay,    &MultiSelectComboBox.XAMLWay.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	    � WindowState$ 	Maximized=�6   .��5      � $��10q�6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $'��!Multi-Select ComboBox in XAML way��6   $��2��6=   $��24(�6Q   �� 5   
   $��Normal ComboBox��6   $��1��6+   �� 5   
   $��1��6   $��1��6#   $	��300��6�   ��60   �� *	Countries+ �� SelectedItem 6R   �� *SelectedCountries+ �� Mode$ TwoWay=�6�   �� 5   
   $��Multi-Select ComboBox��6   $��2��61   �� 5   
   $��1��6   $��2��6#      MultiSelectComboBoxStyle#���   6�   $	��300��6�   ��60   �� *Cities+ 6O   �� *SelectedCity+$ TwoWay=�6�   5      5      