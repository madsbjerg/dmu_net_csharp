   M S B A M L   `   `   `  ????C  ?Opgave02, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Opgave02Opgave02  5   	       Opgave02.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Opgave02     5   	   $	??450??5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ? -   5        $
??grid??5	      $	??450??6    ? RowDefinitions 5
   
   ?? 5      $??20 ?6   6+   ?? 5      6   ?? 5      $??20 ?6   6+    ? ColumnDefinitions 5   
   ?? 5      $	??150??6   60   ?? 5      $	??150??6   60   ?? 5      -   5         ?Name$ TxtBoxColumn??5      $	??150??63   6D   .+?5   
   ?? $??0??6   $??1??6%    ?? Orientation$ Vertical=?62   $??Center=?6K   .+?5      ?? .??6   Name:6   ?? 5      .??6   Age:6   ?? 5      .??6   Score:6   ?? 5      .??6   	Weight:6   ?? 5      .??6   
Accepted6   5      ?? 5   
   $??1??6   $??1??6%   $ Vertical=?62   $??Center=?6K   .+?5      ?? -   5        $
??Name??5      $??5q?6=   $??50??6H   ??6"   ??  ?? Path$
 Name?6X   ?? 5       -   5        $	??Age??5       $??5q?6;   ??6!   ?? $	 Age?6H   ?? 5!      -   5        $??Score??5!      $??5q?6?   ??6#   ?? $ Score?6L   ?? 5"      -   5        $??Weight??5"      $??5q?6A   ??6$   ?? $ Weight?6N   ?? 5#      -   5        $??Accepted??5#       d? 	IsChecked 6'   ?? $ Accepted?6M   5$      ?? 5%   
   -   5        $??Print??5%      $??1??6    $??2??6-   $	??150??6=   6K   ?? 5'   
   -	   5        $??	NewPerson??5'      $??2??6"   .??6G   	Ny person6R   ?? 5(   
   -
   5        $??PrintConsole??5(      $??2??6%   $??1??62   .??6]   Print to Console6o   ?? 5)   
   -   5        $??Suicide??5)      $??2??6    $??2??6-   .??6=   Commit6E   5*      5+      