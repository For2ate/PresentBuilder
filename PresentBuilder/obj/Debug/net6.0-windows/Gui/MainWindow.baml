   M S B A M L   `   `   `  ����I  EPresentBuilder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PresentBuilderPresentBuilder  5   	       PresentBuilder.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PresentBuilder     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � -   5         �Name$ MainRoot��5	      
������� � RowDefinitions 5
   
   �� 5      $
��0.2* �6   6,   �� 5      6   �� 5      $
��0.4* �6   6,   �� 5      6   �� 5      $
��0.2* �6   6,    � ColumnDefinitions 5   
   �� 5      $
��0.1* �6   6.   �� 5      $��0.33* �6   6/   �� 5      $��0.33* �6   6/   �� 5      $��0.33* �6   6/   �� 5      $
��0.1* �6   6.   �� 5      6!   �� 5      $
��0.1* �6   6.   .+�5   
   �� -   5         ��Name$ presentWindow��5      $��1��6*   $��1��6:   $��3��6G   $��3��6X   $��Center=�6l   
�������.��5      �� $
��auto��6   .��5      �� -   5         ��Name$ presentListView��5      $
��auto��64   5      5      �� 5"   
   -   5         ��Name$ sortingByName��5"      $��Название��6)   $��1��6>   $��0��6N   $	��119��6[   $
��Left=�6g   $��15��6�    K� ZIndex$	 100��6�   $��0,8,0,8q�6�   6�   �� 5#   
   -   5        $ sortingByWeight��5#      $��Вес��6*   $��2��6;   $��0��6K   $��Center=�6X   $	��110��6u   $��15��6�   $	 100��6�   $��0,8,0,8q�6�   6�   �� 5$   
   -   5        $ sortingBySugarPercent��5$      $!��Процент сахара��60   $��3��6K   $��0��6[   $	��119��6h   $��15��6t   6�   �� 5&   
   -   5        $ addSweetsButton��5&      $'��!Добавить сладость��6J   $��5��6f   $��Right=�6v   $��3��6�   $��	0,0,10,10q�6�   $��Bottom=�6�   $	��120��6�   $��20��6�   �� 5'   
   -   5        $ deleteSweetsButton��5'      $%��Удалить сладость��6P   $��5��6k   $
��Left=�6{   $��3��6�   $��	10,0,0,10q�6�   $��Bottom=�6�   $	��120��6�   $��20��6�   5)      5*      