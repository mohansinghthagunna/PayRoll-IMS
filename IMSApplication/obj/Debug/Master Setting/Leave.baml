   M S B A M L   `   `   `  ����  IMSApplication)    #IMSApplication.Master_Setting.Leave   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Leave��5   	   $��426.932��6   $	��600��6(   $��426.932��64   $	��600��6H    � 
ResizeMode$ NoResize=�6W    � WindowStartupLocation$ CenterScreen=�6m    � ShowInTaskbar .  .��5      �  � ColumnDefinitions 5   
   �� 5      $	��22* �6   �� 5	      $	��13* �6   �� 5
      $	��17* �6   �� 5      $	��71* �6   �� 5      $	��28* �6   �� 5      $	��27* �6   �� 5      $	��69* �6   �� 5      $	��45* �6   �� 5      $	��13* �6   �� 5      $	��30* �6   �� 5      $	��71* �6   �� 5      $	��15* �6   �� 5      $	��40* �6   �� 5      $	��42* �6   �� 5      $	��12* �6   �� 5      $	��23* �6   �� 5      $	��18* �6   �� 5      $	��20* �6   �� 5      $	��11* �6   �� 5      $��8* �6    � RowDefinitions 5   
   �� 5      $	��45* �6   �� 5      $	��10* �6   �� 5       $	��25* �6   �� 5!      $	��10* �6   �� 5"      $	��24* �6   �� 5#      $��8* �6   �� 5$      $	��26* �6   �� 5%      $	��12* �6   �� 5&      $��5* �6   �� 5'      $	��22* �6   �� 5(      $
��162* �6   �� 5)      $	��30* �6   �� 5*      $	��10* �6   �� 5+      $��9* �6   .+�5.   
   o� $��Center=�6   $	��Top=�6-   $��24��6E   $	��600��6Q   $��20��6]   $��-2,0,-3.252,0q�6r   .@�5/      m� $��Center=�6   $	��New��62    m� Icon$  ��6?   6I   m� 50      $��Center=�6   $
��Edit��62   $  ��6@   6J   m� 51      $��Center=�6   $
��Save��62   $  ��6@   6J   m� 52      $��Center=�6   $��Delete��62   $  ��6B   6L   m� 53      $��Center=�6   $
��Undo��62   $  ��6@   6J   54      �� 56   
   
�������$��1q�6$   $��1��68   $��7��6H   $��1��6Y   $��18��6f   �� 58   
   $��2��6   $��3��6   $��1��6-   $��Leave Id��6A   $
��Left=�6T   $��Center=�6o   6�   �� 59   
   $��4��6   $��3��6   $��
Leave Name��6-   $��2��6B   $
��Left=�6V   $��Center=�6q   6�   �� 5:   
   $��6��6   $��3��6   $��1��6-   $��
Leave Type��6>   $
��Left=�6S   $��Center=�6n   �� 5<   
   $��2��6   $��5��6   $��1��6/   $��2��6@   $��Center=�6T   6r   �� 5=   
   $��4��6   $��5��6   $��1��6/   $��3��6@   $��Center=�6T   6s   �� 5>   
   $��
Paid Leave��6   $��9��6(   $��4��68   $��4��6L   $��1��6Y   $��Center=�6j   6�   �� 5?   
   $��Days(annualy)��6   $��12��6(   $��4��69   $��4��6M   $��1��6Z   $��Center=�6k   6�   �� 5@   
   $��15��6   $��3��6#   $��4��67   $��1��6D   $��Center=�6U   6t   � 5A   
   $��5��6   $��6��6   $��6��63   $��1��6@    5B      �� 5C      $��0* �6    �� 5D      �� 5E      $��0* �6     5G      �� 5H      $��0* �6#   �� 5I      $	��23* �6#   �� 5J      $
��105* �6#   �� 5K      $
��124* �6#   �� 5L      $��3* �6#   .+�5N      �� $��1��6   $��1��6%   $��3��62   $��1��6F   
���   �$��1q�6k   6�   	� 5O      $��Expire Yearly��6   $��2��62   $��2��6B   $��1��6V   $��1��6c   $��Center=�6t   6�   	� 5P      $��Accumulative��6   $��3��61   $��1��6A   $��1��6U   $��1��6b   $��Center=�6s   6�   5R      �� 5S   
   $��Maximum Days��6   $��12��6'   $��4��68   $��6��6L   $��1��6Y   $��Center=�6j   6�   �� 5T   
   $��15��6   $��3��6#   $��6��67   $��1��6D   $��Center=�6U   6s   �� 5W   
   $��
Leave List��6   $��1��6'   $��19��67   $��9��6L   $��4��6Y   6m   &   System.Windows.Controls.DataGrid  5X   
   $��2��6   $��17��6#   $��10��68   $��2��6F      Columns 5Y      4  .System.Windows.Controls.DataGridCheckBoxColumn  5Z      ,  &System.Windows.Controls.DataGridColumn   Header$ S.No.��6_   	   MinWidth$	 35Q�6n   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6)   Z�    ClipboardContentBinding 6<   Z� 6n     5[      $ Leave Id��6_   $	 55Q�6q   
 6)   Z�  6<   Z� 6q     5\      $ 
Leave Name��6_   $		 150Q�6s   
 6)   Z�  6<   Z� 6s     5]      $ 
Leave Days��6_   $	 70Q�6s   
 6)   Z�  6<   Z� 6s     5^      $ 
Leave Type��6_   $	 80Q�6s   
 6)   Z�  6<   Z� 6s     5_      $ Max Days��6_   $	 80Q�6q   
 6)   Z�  6<   Z� 6q     5`      $ 
Paid Leave��6_   $	 70Q�6s   
 6)   Z�  6<   Z� 6s   5d      5g      5h      