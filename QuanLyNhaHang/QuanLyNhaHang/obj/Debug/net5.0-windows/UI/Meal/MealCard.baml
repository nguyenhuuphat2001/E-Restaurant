   M S B A M L   `   `   `  ����H  DQuanLyNhaHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyNhaHangQuanLyNhaHang  5          QuanLyNhaHang.MealCard   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      'localclr-namespace:QuanLyNhaHang  5      $��50��5	      .��5
      � .+�5   
   ��   �� CornerRadius$  10��6   
�������$��5q�6:   ._�5      �  � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� $��Center=�6   $��Center=�66   $��50��6S    � 	Resources 5       �� 
TargetType �� Property �� Value��%_   '��       �� 5      " ��6    .�5      ��  �@��CornerRadius$ 10��6=   5      5      5      �� 5      -   5         ��Name$ mealInfo��5      $��1��6/    �� Orientation$ 
Horizontal=�6?   $
��Left=�6X   .+�5      �� -   5         ��Name$ mealName��5       $��Pork with rice��62   $��	10,0,10,0q�6H   $��Center=�6[   $��Center=�6x   
���   �6�   5      �� 5      -   5        $ mealCategoryContainer��5      $��2��6<   $ 
Horizontal=�6L   $
��Left=�6e   .+�5       �� -   5        $ mealCategory��5        $��	Main dish��66   $��	10,0,10,0q�6G   $��Center=�6Z   $��Center=�6w   
���   �6�   5!      �� 5"      -   5        $ mealPriceContainer��5"      $��3��69   $
��Left=�5#      $��Center=�5$      .+�5%      �� -   5        $ 	mealPrice��5%       $��
100000 Vnd��63   $��	10,0,10,0q�6E   $��Center=�6X   $��Center=�6u   5&      �� 5'      -   5        $ ��mealOrderQuantityContainer��5'      $��4��5(      $
��Left=�6-   $��Center=�6H   .+�5)      �� -   5        $ orderQuantity��5)       $	��100��67   $��	10,0,10,0q�6B   5*      � 5+      -	   5        $��5��5+      $
��Left=�6D    5,      �� 5-      �� 5.      �� 5/      .+�51      �� -
   5        	 ��Name$	 	addButton��51      $��0��60   
�������
�������.��52      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        $��addIcon��52   @   
   Kind$
 Pencil=�62   
�������6O   53      �� 54      $��1��6    $��41��60   $��20��6;   
������� � LayoutTransform 55      �� 56       �� Angle$ 90Q�6.   58      �� 59      -   5        $	 deleteButton��59      $��2��63   
�������
�������.��5:        -   5          Name$ 
deleteIcon��5:   2   $
 
GarbageCan=�6F   
�������6X   5;      5<      5=      5>      5?      5@      