   M S B A M L   `   `   `  ����H  DQuanLyNhaHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyNhaHangQuanLyNhaHang  5           QuanLyNhaHang.BillTemplate   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:QuanLyNhaHang     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$  BillTemplate��5	      $	��793��5
      $
��auto��5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5      .��5      � -   5         �Name$ billGrd��5       � RowDefinitions 5   
   �� 5      $	��120 �6   �� 5      $��35 �6   �� 5      $
��auto �6   �� 5      $��30 �6   �� 5      $	��100 �6   .+�5   
   �  � ColumnDefinitions 5      �� 5      �� 5      .+�5      � -   5        $ restaurantInformation��5      $��Center=�62   .+�5      �� $	��110��6   $"��/MainTemplate/restaurant.png��6%   5      �� 5"      $��1��5#      
��� � �$��5q�5%       �� CornerRadius$ 10��5&      ._�5'      �  5(      �� 5)      �� 5*      �� 5+      �� 5,      .+�5.      � -   5        $ invoiceIDContainer��5.      $��0��67   .+�5/      �� -   5         ��Name$ 	invoiceID��50      $��Center=�51      $��Center=�52      $��20(�53      $��Invoice Number 1111��54      55      � 56      -   5        $ dateCheckinContainer��56      $��1��69   .+�57      �� $��Center=�58      $��Center=�59       �� Orientation$ 
Horizontal=�5:      .+�5;      �� $��Center=�5<   !   $��Center=�5=   !   $��20(�5>   !   $��Date check in: ��5?   !   �� 5@      -   5        $ dateCheckinTxb��5A   !   $��Center=�5B   !   $��Center=�5C   !   $��20(�5D   !   $��18:00 28/1/2021��5E   !   5F      5G      � 5H      -   5        $ dateCheckOutContainer��5H      $��2��6:   .+�5I      �� $��Center=�5J      $��Center=�5K      $ 
Horizontal=�5L      .+�5M      �� $��Center=�5N   !   $��Center=�5O   !   $��20(�5P   !   $��Date check out: ��5Q   !   �� 5R      -   5        $ dateCheckOutTxb��5S   !   $��Center=�5T   !   $��Center=�5U   !   $��20(�5V   !   $��21:00 28/1/2021��5W   !   5X      5Y      � 5Z      -	   5        $ staffIDContainer��5Z      $��3��65   .+�5[      �� -
   5        $ staffID��5\      $��Center=�5]      $��Center=�5^      $��20(�5_      $��Staff ID: 1111��5`      5a      5b      5c      5e      � 5f   
   $��1��6   .+�5g      #  MaterialDesignThemes.Wpf.Card  
������6"   �� 5h      -   5        $ invoice��5i      $��0��5j      $��1��5k      $��100,0q�5l      $��Right=�5m      $��Center=�5n      $��25(�5o      $��Italic$�5p      $��Invoice: #1001��5q      5r      &   System.Windows.Controls.DataGrid  5t   
   -   5        	  Name$	 gridBill��5u      $��2��5v      $
��0,10q�5w      
   AutoGenerateColumns$

 True��5x      $��19(�5z       � UseLayoutRounding$ False��5{      � 5|   
   $��3��6    5}      �� 5~      $��2* �6#   �� 5      �� 5�      $��2* �6#   .+�5�      �� -   5        $ subTotalTxb��5�      $
��20,0q�5�      $��Bottom=�5�      $��15(�5�      $
��Bold"�5�      $��
Subtotal: ��5�      �� 5�      -   5        $ discountTxb��5�      $��1��5�      $��Bottom=�5�      $��15(�5�      $
��Bold"�5�      $��
Discount: ��5�      �� 5�      -   5        $ totalTxb��5�      $��2��5�      $��Bottom=�5�      $��20(�5�      $
��Bold"�5�      $��Total: ��5�      5�      � 5�   
   $��4��6   $��0,20,0,0q�6    5�      �� 5�      �� 5�      .+�5�      � $��0��6   .+�5�      �� $��Center=�5�      $��Center=�5�      $��Blackadder ITC)�5�      $��40(�5�      $��Italic$�5�      $
��Bold"�5�      
��� � �$"��Thanks for choosing us today��5�      5�      � 5�      $��1��6   .+�5�      �� -   5         ��Name$ exportBillBtn��5�      $��78��5�      $��63��5�      $��0,0,50,0q�5�      $��Right=�5�      $��Center=�5�      .��5�      '  !MaterialDesignThemes.Wpf.PackIcon  $��39��5�      $��90��5�      $��Center=�5�      $��Center=�5�      $��15(�5�      
�������   Kind$ Printer=�5�      5�      5�      5�      5�      5�      