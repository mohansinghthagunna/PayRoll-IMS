   M S B A M L   `   `   `  ����  IMSApplication    
IMS.Branch   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Branch��5   	   $��426.932��6   $��543.233��6)   $��426.932��69   $��543.233��6M    � 
ResizeMode$ NoResize=�6`    � WindowStartupLocation$ CenterScreen=�6v    � ShowInTaskbar .  .��5      �  � ColumnDefinitions 5   
   �� 5	      $	��20* �6   �� 5
      $	��12* �6   �� 5      $	��15* �6   �� 5      $	��65* �6   �� 5      $	��25* �6   �� 5      $	��24* �6   �� 5      $	��62* �6   �� 5      $	��41* �6   �� 5      $	��39* �6   �� 5      $
��114* �6   �� 5      $	��69* �6   �� 5      $	��16* �6   �� 5      $	��14* �6   �� 5      $	��21* �6    � RowDefinitions 5   
   �� 5      $	��45* �6   �� 5      $	��10* �6   �� 5      $	��25* �6   �� 5      $	��10* �6   �� 5      $	��24* �6   �� 5      $��8* �6   �� 5      $��5* �6   �� 5       $	��22* �6   �� 5!      $	��11* �6   �� 5"      $��5* �6   �� 5#      $	��22* �6   �� 5$      $
��162* �6   �� 5%      $	��11* �6   �� 5&      $��6* �6   �� 5'      $	��23* �6   �� 5(      $��9* �6   .+�5+   
   o� $��Center=�6   $	��Top=�6-   $��24��6E   $	��537��6Q   $��14��6]   .@�5,      m� $��Center=�6   $	��New��62    m� Icon$  ��6?   6I   m� 5-      $��Center=�6   $
��Edit��62   $  ��6@   6J   m� 5.      $��Center=�6   $
��Save��62   $  ��6@   6J   m� 5/      $��Center=�6   $��Delete��62   $  ��6B   6L   m� 50      $��Center=�6   $
��Undo��62   $  ��6@   6J   51      �� 53   
   
�������$��1q�6$   $��1��68   $��8��6H   $��1��6Y   $��12��6f   �� 55   
   $��2��6   $��3��6   $��1��6-   $��	Branch Id��6A   $
��Left=�6U   $��Center=�6p   6�   �� 56   
   $��4��6   $��3��6   $��Branch Name��6-   $��2��6C   $
��Left=�6W   $��Center=�6r   6�   �� 58   
   $��2��6   $��5��6   $��1��6/   $��4��6@   $��Center=�6T   6s   �� 59   
   $��4��6   $��5��6   $��1��6/   $��5��6@   $��Center=�6T   6s   �� 5:   
   $��7��6   $��5��6    $��2��60   �� 5;   
   $��
Out Branch��6   $��6��6%   $��6��62   $��2��6B   $��2��6V   �� 5=   
   $��Branch List��6   $��1��6(   $��12��68   $��10��6M   $��3��6[   6n   &   System.Windows.Controls.DataGrid  5>   
   $��2��6   $��10��6#   $��11��68   $��1��6F      Columns 5?      4  .System.Windows.Controls.DataGridCheckBoxColumn  5@      ,  &System.Windows.Controls.DataGridColumn   Header$ S.No.��6_   	   MinWidth$	 40Q�6n   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6)   Z�    ClipboardContentBinding 6<   Z� 6n     5A      $ 	Branch Id��6_   $	 70Q�6r   
 6)   Z�  6<   Z� 6r     5B      $ Branch Name��6_   $		 180Q�6t   
 6)   Z�  6<   Z� 6t     5C      $ 
Out Branch��6_   $		 180Q�6s   
 6)   Z�  6<   Z� 6s   5F      �� 5I   
   $��14��6   $��1��6   $��1��60   $��12��6@   $8��2Set Employee for Branchwise Attendance Restriction��6U   5J      5K      