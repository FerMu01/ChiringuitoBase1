   M S B A M L   `   `   `  ����I  EChiringuitoWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:ChiringuitoWPF.AcademicManageChiringuitoWPF.AcademicManage  5   	   ,    &ChiringuitoWPF.AcademicManage.winAdmin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:ChiringuitoWPF.AcademicManage     5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
      MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � Title$ winAdmin��5   	   $	��450��6   $	��900��6'    � WindowStyle$ 
ToolWindow=�63    � 
ResizeMode$ NoResize=�6L    � WindowStartupLocation$ CenterScreen=�6b   .��5      � .+�5   
   �� $
��Left=�6   $	��434��6/   $��-6,0,0,0q�6<   
���   �$��Center=�6]   $	��906��6x   
������� �� RadiusX$ 48.256��6�    �� RadiusY$ 48.256��6�   �� 5   
   $
��Left=�6   $	��434��6/   $��	386,0,0,0q�6<   $��Center=�6O   $��61��6j   ���	#FF79100D$ 0��6�   $ 0��6�   �� 5   
   $
��Left=�6   $	��434��6/   $��-6,0,0,0q�6<   $��Center=�6N   $	��453��6i   $ 48.256��6u   $ 48.256��6�   ��5      �� 5       �� ImageSource$" /AcademicManage/interfaz.png��6   5      �� 5   
   $
��Left=�6   $	��434��6/   $��	447,0,0,0q�6<   $��Center=�6O   $��78��6j   ���	#FFFF3535$ 0��6�   $ 0��6�   �� 5   
   $
��Left=�6   $	��434��6/   $��	447,0,0,0q�6<   $��Center=�6O   $	��453��6j   $ 48.256��6v   $ 48.256��6�   ��5      �� 5      $$ /AcademicManage/interfaz 2.png��6   5      �� 5   
   $
��Left=�6   $��7��6/   $��517,166,0,0q�6:   $	��Top=�6O   $	��316��6g   ��5       �� 5!      	 �� EndPoint$	 0.5,1&�6&   
 �� 
StartPoint$
 0.5,0&�67   .��5"      �  � Color$ Black��6#   � 5#      $ 	#FFFF0D07��6#    � Offset$ 1Q�65   5$      5&      �� 5'   
   $
��Left=�6   $��7��6/   $��517,251,0,0q�6:   $	��Top=�6O   $	��316��6g   ��5(      �� 5)      $	 0.5,1&�6&   $
 0.5,0&�67   .��5*      � $ Black��6#   � 5+      $ 	#FFFF0D07��6#   $ 1Q�65   5,      5.      �� 5/   
   -   5         ��Name$ btnIngresar��5/      $��Ingresar��6&   $��36��69   $��723,335,0,0q�6E   $	��Top=�6Z   ���	#FF01C4DA$��Impact)�6�   $��19(�6�   $
��Left=�6�   $
��Thin"�6�   6�   �� 50   
   -   5        $ 	btnVolver��50      $��Salir��6$   $��36��64   $��530,335,0,0q�6@   $	��Top=�6U   ���	#FF01C4DA$��Impact)�6�   $��19(�6�   $
��Left=�6�   $��
UltraLight"�6�   6�   �� 51   
    �� Orientation$ 
Horizontal=�6   $��2��6.   $��Center=�6;   $��40��6V   $	��313��6b   $��450,-130,0,0q�6n   .+�52      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�6&   
�������$��Center=�53   1   $��	0,20,10,0q�6L   $��Center=�6_   $��22��6|   $��22��6�   54      �� 55      -   5         ��Name$ textUsername��55      
������� % !MaterialDesignFloatingHintTextBox#��[ 56      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nombre De Usuario��57      $	��280��6A   $��50��6M   $��0,0,10,0q�6Y    �� SelectionOpacity$ 1Q�6k   $
��Bold"�6�   $��18(�6�   $��Arial)�6�   58      �� 59   
   $ 
Horizontal=�6   $��2��6.   $��Center=�6;   $��40��6V   $	��313��6b   $��
450,40,0,0q�6n   .+�5:        $ Password=�6&   
�������$��Center=�5;   !   $��	0,15,10,0q�6<   $��Center=�6O   $��22��6l   $��20��6w   5<      G� 5=      -   5         G�Name$ textPassword��5=      
�������$	��280��5?      $��40��6   $��	0,15,10,0q�6&   $ Ingresa Tu Contraseña��5@      $��18(�6E   $��Arial)�6S   $
��Bold"�6f   5A      5C      5D      