   M S B A M L   `   `   `  ����H  DQuanLyNhaHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyNhaHangQuanLyNhaHang  5           QuanLyNhaHang.CategoryCard   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      'localclr-namespace:QuanLyNhaHang  5      $��50��5	      .��5
      � .+�5   
   ��   �� CornerRadius$  10��6   
�������$��5q�6:   ._�5      �  � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� $��Center=�6   $��Center=�66   $��50��6S    � 	Resources 5       �� 
TargetType �� Property �� Value��%_   '��       �� 5      " ��6    .�5      ��  �@��CornerRadius$ 10��6=   5      5      5      �� 5      -   5         ��Name$ categoryIDContainer��5      $��1��6:    �� Orientation$ 
Horizontal=�6J   .+�5      �� -   5         ��Name$ tbkID��5       $��1��6/   $��	10,0,10,0q�68   $��Center=�6K   $��Center=�6h   
���   �6�   5      �� 5      -   5        $ categoryName��5      $��2��63   $ 
Horizontal=�6C   .+�5       �� -   5        $ tbkName��5        $��	Main dish��61   $��	10,0,10,0q�6B   $��Center=�6U   $��Center=�6r   
���   �6�   5!      � 5#      $��3��6   $
��Left=�6'    5$      �� 5%      �� 5&      �� 5'      .+�5)      �� -   5        	 ��Name$	 
editButton��5)      $��0��61   
�������
�������.��5*      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        $��editIcon��5*   @   
   Kind$
 Pencil=�62   
�������6P   5+      �� 5,      $��1��6    $��41��60   $��20��6;   
������� � LayoutTransform 5-      �� 5.       �� Angle$ 90Q�6.   50      �� 51      -   5        $	 deleteButton��51      $��2��63   
�������
�������.��52        -   5          Name$ 
deleteIcon��52   2   $
 
GarbageCan=�6F   
�������6X   53      54      55      56      57      58      