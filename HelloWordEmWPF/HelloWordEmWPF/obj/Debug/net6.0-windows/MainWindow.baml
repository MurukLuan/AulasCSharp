   M S B A M L   `   `   `  ����I  EHelloWordEmWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:HelloWordEmWPFHelloWordEmWPF  5   	       HelloWordEmWPF.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:HelloWordEmWPF     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   
     � Title$  Meu Primeiro WPF��5   	   $	��450��6"   $	��500��6/      MaterialDesignBody#���   5   
   $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper#���  5   
     MaterialDesignFont#���  5   
   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5"   
   �� .��6   Nomes6   �� 5#   
   -   5         ��Name$ listarNomes��5#      $��1��6   6   �� 5%   
   $��1��6   $��1��6"   $��5 , 0, 0, 0q�62   .+�5&      �� -   5         ��Name$ txtNome��5&      �� 5'      -   5         ��Name$ btnAdd��5'      $��
0, 5, 0, 0q�6%   .��6U   	Adicionar6`   5(      �� 5)   
   $��1��6   $��1��6"   .@�5*      �� $	��224��6   $	��231��6'   .��63   Primeiro Item6B   �� 5+      .��6   Segundo Item6(   5,      5/      50      