   M S B A M L   `   `   `  ����H  DQuanLyNhaHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyNhaHangQuanLyNhaHang  5          QuanLyNhaHang.TableCard   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      'localclr-namespace:QuanLyNhaHang  5      $��50��5	      .��5
      � .+�5   
   ��   �� CornerRadius$  10��6   
�������$��5q�6:   ._�5      �  � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� $��Center=�6   $��Center=�66   $��50��6S    � 	Resources 5       �� 
TargetType �� Property �� Value��%_   '��       �� 5      " ��6    .�5      ��  �@��CornerRadius$ 10��6=   5      5      5      �� 5      -   5         ��Name$ 	tableName��5      $��1��60    �� Orientation$ 
Horizontal=�6@   .+�5      �� -   5         ��Name$ tbkName��5       $��1��61   $��Center=�6;   $��Center=�6X   
���   �6s   5      �� 5      -   5        $ tableStatus��5      $��2��62   $ 
Horizontal=�6B   .+�5       �� -   5        $ 	tbkStatus��5        $��Reversed��63   $��Center=�6C   $��Center=�6`   
���   �6{   5!      � 5$      $��5��6   $
��Left=�6'    5%      �� 5&      �� 5'      �� 5(      .+�5*      �� -   5        	 ��Name$	 	addButton��5*      $��0��60   
�������
�������.��5+      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        $��addIcon��5+   @   
   Kind$
 Pencil=�62   
�������6O   5,      �� 5-      $��1��6    $��41��60   $��20��6;   
������� � LayoutTransform 5.      �� 5/       �� Angle$ 90Q�6.   51      �� 52      -   5        $	 deleteButton��52      $��2��63   
�������
�������.��53        -   5          Name$ 
deleteIcon��53   2   $
 
GarbageCan=�6F   
�������6X   54      55      56      57      58      59      