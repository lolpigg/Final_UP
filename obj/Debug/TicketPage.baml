   M S B A M L   `   `   `  ����K  GFinal_Project_UP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Final_Project_UPFinal_Project_UP  5      !    Final_Project_UP.TicketPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Final_Project_UP     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  
TicketPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      $��4* �6   6*    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGrid��5      $��2��6P   $��20��6]   6r   �� 5   
   -   5         ��Name$ trip_id��5   9   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Рейс��6   $��1��6J   $��Stretch=�6W   $��Stretch=�6u   $��Bottom=�6�   6�   �� 5   
   -   5        $ 
benefit_id��5   ;   $ Льгота��6   $��1��6O   $��1��6_   $��Stretch=�6m   $��Stretch=�6�   $��Bottom=�6�   6�   �� 5   
   -   5        $ passenger_id��5   =   $ Пассажир��6   $��2��6S   $��1��6c   $��Stretch=�6q   $��Stretch=�6�   $��Bottom=�6�   6�   �� 5   
   -   5         ��Name$ payment��5      $��3��6#   $��1��63   $ Внесено��6@   $��Stretch=�6i   $��Stretch=�6�   $��Bottom=�6�   6�   �� 5   
   -   5         ��Name$ Create��5      $��Создать��6"   $	��NaN��65   6Y   �� 5   
   -   5        $ Change��5      $��Изменить��6!   $��1��64   $	��NaN��6E   6i   �� 5   
   -   5        $ Delete��5      $��Удалить��6!   $��2��63   $��1��6C   $	��NaN��6W   6{   �� 5    
   -	   5        $ ToTxt��5       $��Распечатать��6    $��3��66   $��1��6F   $	��NaN��6Z   6}   5!      5"      