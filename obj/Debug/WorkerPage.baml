   M S B A M L   `   `   `  ����K  GFinal_Project_UP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Final_Project_UPFinal_Project_UP  5      !    Final_Project_UP.WorkerPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Final_Project_UP     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  
WorkerPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      $��4* �6   6*    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGrid��5      $��2��6P   $��6��6]   6q   �� 5   
   -   5         ��Name$	 fio��5      $��1��6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ ФИО��6,   $��Bottom=�6Q    �� SelectionTextBrush �	#03FFFFFF6�   �� 5   
   -   5        $	 sex��5      $��1��6   $��1��6/   $ Пол��6<   $��Bottom=�6a    �	#03FFFFFF6�   �� 5   
   -   5        $ 
expirience��5      $��2��6&   $��1��66   $ Стаж��6C   $��Bottom=�6i    �	#03FFFFFF6�   �� 5   
   -   5        $ 
profession��5      $��3��6&   $��1��66   $ Профессия��6C   $��Bottom=�6n    �	#03FFFFFF6�   �� 5   
   -   5        $	 age��5      $��4��6   $��1��6/   $ Возраст��6<   $��Bottom=�6e    �	#03FFFFFF6�   �� 5    
   -   5         ��Name$ logs_id��5    9   $ Логи��6   $��5��6J   $��1��6Z   $��Stretch=�6g   $��Stretch=�6�   $��Bottom=�6�   6�   �� 5!   
   -   5         ��Name$ Create��5!      $��Создать��6!   $	��NaN��63   $��2��6U   6k   �� 5"   
   -	   5        $ Change��5"      $��Изменить��6!   $��2��64   $	��NaN��6D   $��2��6f   6|   �� 5#   
   -
   5        $ Delete��5#      $��Удалить��6!   $��4��63   $	��NaN��6C   $��2��6e   6{   5$      5%      