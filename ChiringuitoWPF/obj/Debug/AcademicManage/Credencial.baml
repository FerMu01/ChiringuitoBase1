   M S B A M L   `   `   `  ����I  EChiringuitoWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:ChiringuitoWPF.AcademicManageChiringuitoWPF.AcademicManage  5   	   .    (ChiringuitoWPF.AcademicManage.Credencial   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:ChiringuitoWPF.AcademicManage     5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ 
Credencial��5   	   $	��500��6   $	��800��6)    � 
ResizeMode$ NoResize=�65    � WindowStyle$ 
ToolWindow=�6K    � WindowStartupLocation$ CenterScreen=�6d   .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��1��6   $��Stretch=�5      $��Stretch=�5      .��5      �� $)��#/AcademicManage/inter register1.png��6   $��UniformToFill=�6A   5      5      � 5   
   $��0��6   $	��Top=�6    � RowDefinitions 5      �� 5       6"   �� 5!      6"   �� 5"      6"   �� 5#      6"   �� 5$      6"   �� 5%      6"   �� 5&      6"   �� 5'      $��* �6    6-   .+�5*      �� $��0��6      MaterialDesignBody1TextBlock#��[ 5+      $��Center=�5,      EL CHIRINGUITO5.      �� 5/       �� Orientation$ 
Horizontal=�6   $��1��62   $��Center=�6?   $��40��6Z   $	��313��6f   .+�50      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 	AlphaNBox=�6*   $��Center=�51   h   $��0,5,10,0q�6�   $��Center=�6�   ��6*   �� 
 �� ElementName$
 textName�� �� Path$ BorderBrush�52      �� 53      -   5         ��Name$ TextName��53       % !MaterialDesignFloatingHintTextBox#��[ 54      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nombre��55      $	��250��6B   $��40��6N   $��
0,-10,10,0q�6Z   56      �� 57      $ 
Horizontal=�6   $��2��62   $��Center=�6?   $��40��6Z   $	��313��6f   .+�58        $	 	AlphaABox=�6*   $��Center=�59   h   $��0,5,10,0q�6�   $��Center=�6�   ��6*   �� $
 TextName��$ BorderBrush�5:      �� 5;      -   5        $ 
TextPrimer��5;      #��[ 5<      $ Primer Apellido��5=      $	��250��6K   $��40��6W   $��
0,-10,10,0q�6c   5>      �� 5?      $ 
Horizontal=�6   $��3��62   $��Center=�6?   $��40��6Z   $	��313��6f   .+�5@        $	 	AlphaSBox=�6*   $��Center=�5A   h   $��0,5,10,0q�6�   $��Center=�6�   ��6*   �� $
 textName��$ BorderBrush�5B      �� 5C      -   5        $ TextSegundo��5C      #��[ 5D      $ Segundo Apellido��5E      $	��250��6L   $��40��6X   $��
0,-10,10,0q�6d   5F      �� 5G      $ 
Horizontal=�6   $��4��62   $��Center=�6?   $��40��6Z   $	��313��6f   .+�5H        $
	 Mail=�6*   $��Center=�5I   h   $��0,5,10,0q�6�   $��Center=�6�   ��6*   �� $
 textName��$ BorderBrush�5J      �� 5K      -   5        $ textMail��5K      #��[ 5L      $ Correo Electrònico��5M      $	��250��6N   $��40��6Z   $��
0,-10,10,0q�6f   5N      �� 5O      $ 
Horizontal=�6   $��5��62   $��Center=�6?   $��40��6Z   $	��313��6f   .+�5P        $	 Calendar=�6*   $��Center=�5Q   h   $��0,5,10,0q�6�   $��Center=�6�   ��6*   �� $
 textName��$ BorderBrush�5R      (  "System.Windows.Controls.DatePicker  5S      -   5          Name$ DatePickerFecha��5S       ( $MaterialDesignFloatingHintDatePicker#��[ 5T      $ Fecha de Nacimiento��5U      $	��250��6R   $��40��6^   $��
0,-10,10,0q�6j      DisplayDate$ 
2006-05-17��6~      DisplayDateEnd$ 
2006-05-17X�6�   5V      �� 5W      -   5         ��Name$ btnSiguiente��5W      $��6��5X      $��	Registrar��5Y      $��Center=�5Z      $��Center=�5[      $	��100��5\      $��40��5]      $��0,20,0,0q�5^        MaterialDesignRaisedButton#��[ 5_      ���	#FF03C3DA6`   5`      �� 5a   
   -   5        $ 	btnVolver��5a      $��Volver��6$   $
��Left=�65   $��200,368,0,0q�6P   $	��Top=�6e   6}   5b      5c      