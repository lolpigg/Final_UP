   M S B A M L   `   `   `  ����K  GFinal_Project_UP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Final_Project_UPFinal_Project_UP  5   	   "    Final_Project_UP.AdminWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Final_Project_UP     5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  AdminWindow��5	   	   $	��540��6   $	��960��6*   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��8* �6   6,   �� 5      6!   �� 5       � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� -   5         ��Name$ role_but��5      $��1��6#   $��0��63   $	��NaN��6@   $��Роли��6M   6\   �� 5   
   -   5        $ logs_but��5      $��1��6#   $��1��63   $	��NaN��6@   $��Логи��6M   6u   �� 5   
   -   5        $ 
worker_but��5      $��1��6%   $��2��65   $	��NaN��6B   $��Рабочие��6O   6|   �� 5   
   -   5        $ passenger_but��5      $��1��6(   $��3��68   $	��NaN��6E   $��Клиенты��6R   6�   �� 5   
   -   5        $ benefit_but��5      $��1��6&   $��4��66   $	��NaN��6C   $��Льготы��6P   6}   �� 5   
   -   5        $ 	model_but��5      $��1��6$   $��5��64   $	��NaN��6A   $��Модели��6N   6y   �� 5   
   -   5        $ 	train_but��5      $��2��6$   $��0��64   $	��NaN��6A   $��Поезда��6N   6y   �� 5   
   -   5        $ 	route_but��5      $��2��6$   $��1��64   $	��NaN��6A   $��Маршрут��6N   6z   �� 5    
   -	   5        $ routes_of_trains_but��5       $��2��6/   $��2��6?   $	��NaN��6L   $��Мар-Пое��6Y   6�   �� 5!   
   -
   5        $ trip_but��5!      $��2��6#   $��3��63   $	��NaN��6@   $��Рейс��6M   6u   �� 5"   
   -   5        $ list_of_passengeres��5"      $��2��6.   $��4��6>   $	��NaN��6K   $��Рей-Пас��6X   6�   �� 5#   
   -   5        $ 
ticket_but��5#      $��2��6%   $��5��65   $	��NaN��6B   $��Билеты��6O   6{    � 5$   
   -   5          �Name$ 	PageFrame��5$      $��6��6#     � NavigationUIVisibility$ Hidden=�64   6V   5%      5&      