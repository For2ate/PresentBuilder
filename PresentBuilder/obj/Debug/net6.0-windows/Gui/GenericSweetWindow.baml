   M S B A M L   `   `   `  ����I  EPresentBuilder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:PresentBuilder.GuiPresentBuilder.Gui  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   +    %PresentBuilder.Gui.GenericSweetWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:PresentBuilder.Gui     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   -   5          �Name$  genericWindow��5   	    � Title$ GenericSweetWindow��5
   	   $	��250��6$   $	��400��61    � 
ResizeMode$ NoResize=�5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $��25 �6   6.   �� 5      $��122.667 �6   63   �� 5      $��32.333 �6   �� 5      $��30 �6   6.   �� 5      $	��155 �6   6/   �� 5      $��25 �6   6.    � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      $��20 �6   6*   �� 5      $��30 �6   6*   �� 5      $��20 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   .+�5    
   �� -   5         ��Name$ nameTextBox��5       $��1��6'   $��1��64   $��2��6d   6z   �� 5!   
   -   5        $ hintNameTextBox��5!      $��1��6+   $��1��68   $6��0Введите название сладости��6H   ${�False��6j    J� IsHitTestVisible$ False��6|   $��2��6�   6�   �� 5"   
   -   5        $ weightTextBox��5"      $��3��6)   $��1��66   $��2��6g   6}   �� 5#   
   -   5        $ hintWeightTextBox��5#      $��3��6-   $��1��6:   $3��-Введите вес сладости(гр.)��6J   ${�False��6k   $ False��6}   $��2��6�   6�   �� 5$   
   -   5         ��Name$ hintSugarPersent��5$      $8��2Процент сахара в сладости 0%��6.   $��4��6R   $��1��6`   $��0,7,15,7q�6p   $��16��6�   $	��170��6�   $��10(�6�   $��3��6�   �� 5%   
   -   5         ��Name$ sugarPecentSlider��5%      $��5��6,   $��1��69   	 � Value$	 0Q�6I   
 � Maximum$	
 100Q�6S    � Minimum$ 0Q�6a    �� IsSelectionRangeEnabled$
 True��6m   $��0,5,0,5q�6�   $��2��6�   �� 5'   
   $��1��6   $��0��6$   $��Название��61   $��0,30,0,0q�6A   �� 5(   
   $��1��6   $��2��6$   $��Вес��61   $��0,10,0,0q�6<   �� 5+   
   -   5         ��Name$ comboBoxType��5+      $��1��6)   $��4��66    �� 
IsEditable$
 True��6H    �� 
IsReadOnly$
 True��6[    �� Text$. (Выберите тип сладости��6m   .@�5,      ��Конфета��6"   ��5-      Печенька��6#   5.      �� 50   
   -	   5        $ innerTypeBox��50      $��3��6)   $��4��66   $
 True��6F   $
 True��6Y   $. (Выберите тип сладости��6k   51      �� 53   
   -
   5         ��Name$ 	addSweets��53      $��Добавить��6$   $��4��69   $��6��6I   6V   55      56      