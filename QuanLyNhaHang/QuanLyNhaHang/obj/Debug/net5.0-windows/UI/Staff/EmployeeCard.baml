   M S B A M L   `   `   `  ����H  DQuanLyNhaHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyNhaHangQuanLyNhaHang  5           QuanLyNhaHang.EmployeeCard   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      'localclr-namespace:QuanLyNhaHang  5      $��50��5	      .��5      � .+�5   
   ��   �� CornerRadius$  10��6   
�������$��0,5,0,5q�6:   ._�5   
   �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Center=�6   $��Center=�6.   $��50��6K    � 	Resources 5       �� 
TargetType �� Property �� Value��%_   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 10��65   5      5      5      �� 5   
   -   5         ��Name$  employeeBasicInfoContainer��5      $��1��69    �� Orientation$ 
Horizontal=�6I   .+�5      A� -   5         A�Name$ employeeAvatar��5      $��23��6.   $��23��6:   6G   �� 5      -   5        	 ��Name$	 employeeName��5      $��Nguyen Doan Thinh��6.   $��Center=�6G   $��Center=�6d   
���   �6   5       �� 5!   
   -   5        $ employeeSalaryContainer��5!      $��2��66   .+�5"      �� -   5        $	 	salaryTxb��5"      $��
100000 Vnd��6+   �� 5#      -   5        $	 workType��5#   *   $��0,10,0,0q�6   $��	Intership��6<   
�������$��10(�6a   5$      �� 5%   
   -   5        $��employeePosition��5%      $��3��6-   .+�5&      �� -   5        $	 workingPosition��5&      $
��Chef��61   $��10,0,0,0q�6=   �� 5'      -	   5        $	 workingPeriod��5'   +   $��	10,10,0,0q�6   $��2 month��6B   $��10(�6Q   
�������$��Bottom=�6r   5(      � 5)   
   $��4��6    5*      �� 5+      �� 5,      �� 5-      .+�5/      �� -
   5        
 ��Name$
 	addButton��5/      $��0��6(   
�������
�������.��50      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        $��addIcon��50   8      Kind$ Pencil=�6*   
�������6G   51      �� 52      $��1��6   $��41��6(   $��20��63   
������� � LayoutTransform 53      �� 54       �� Angle$ 90Q�6&   56      �� 57      -   5        $
 deleteButton��57      $��2��6+   
�������
�������.��58        -   5          Name$ 
deleteIcon��58   *   $ 
GarbageCan=�6>   
�������6P   59      5:      5<      5=      5>      5@      