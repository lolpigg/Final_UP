   M S B A M L   `   `   `  ����K  GFinal_Project_UP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Final_Project_UPFinal_Project_UP  5          Final_Project_UP.LogsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Final_Project_UP     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  LogsPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      $��4* �6   6*    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   .+�5    
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGrid��5       $��2��6P   $��12��6]   6�   �� 5!   
   -   5         ��Name$ login��5!   &   $��4��6   $��1��65   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Логин��6B   $��Bottom=�6i    �� SelectionTextBrush �	#03FFFFFF6�   G� 5"   
   -   5         G�Name$ password��5"   +   $��4��6   $��4��6=   $��1��6M   $ Пароль��6Z   $��Bottom=�6�    G� SelectionTextBrush �	#03FFFFFF6�   �� 5#   
   -   5        	 ��Name$	 role_id��5#      $ Роль��6$   $��8��6J   $��4��6Z   $��1��6n   $��Stretch=�6{   $��Stretch=�6�   $��Bottom=�6�   6�   �� 5$   
   -   5        
 ��Name$
 Create��5$   %   $��3��6   $��Создать��65   $	��NaN��6G   6k   �� 5%   
   -   5        $
 Change��5%   %   $��3��6   $��Изменить��65   $��3��6H   $	��NaN��6X   6|   �� 5&   
   -   5        $
 Delete��5&   %   $��3��6   $��Удалить��65   $��6��6G   $	��NaN��6W   6{   �� 5'   
   -   5        $
 FromJson��5'   %   $��3��6   $��Импорт JSON��67   $��9��6M   $	��NaN��6]   6�   5(      5)      