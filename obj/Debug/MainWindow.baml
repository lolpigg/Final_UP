   M S B A M L   `   `   `  ����K  GFinal_Project_UP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Final_Project_UPFinal_Project_UP  5   	   !    Final_Project_UP.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Final_Project_UP     5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   
�������  � Title$  
MainWindow��5
   	   $	��250��6   $	��400��6)   .��5      � $��5,5,5,5q�6    � RowDefinitions 5   
   �� 5      $	��34* �6   6+   �� 5      $	��30* �6   6+   �� 5      $	��30* �6   6+   �� 5      $	��33* �6   6+   �� 5      $	��23* �6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��2��6   $&�� Добро пожаловать!��6(    �� TextAlignment$ Center=�6A   $��22(�6X   
���   �6{   �� 5   
   -   5         ��Name$ loginbox��5      $��2��6$   $��1��68   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Логин��6E   $��0,0,0,5q�6l   $��Bottom=�6}    �� SelectionTextBrush
 ���� 6�   G� 5   
   -   5         G�Name$ passwordbox��5      $��2��6+   $��2��6?   $ Пароль��6L   $��0,5,0,0q�6t   $��Bottom=�6�    G� SelectionTextBrush �	#03FFFFFF6�   �� 5   
   -   5        	 ��Name$	 Enter��5      $��
Войти��6    $��4��60   $��0,0,5,0q�6=   $��12(�6N   6\   �� 5   
   -   5        $	 
Enter_User��5      $0��*Войти как пользователь��6%   $��4��6F   $��2��6S   $��5,0,0,0q�6c   $��12(�6t   6�   5      5      