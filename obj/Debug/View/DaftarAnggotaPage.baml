   M S B A M L   `   `   `  ����E  APerpusDong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PerpusDong.ViewPerpusDong.View  5   	   '    !PerpusDong.View.DaftarAnggotaPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PerpusDong.View     5   	     � Title$  DaftarAnggotaPage��5   	   $	��450��6#   $	��800��60   
����d�.��5	      � .+�5
   
   �� 
�������$��10,122,10,10q�6$   .+�5      ��  �� Left$ 0��6   
 �� Top$ 10��6)   $	��752��69   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	dgAnggota��5      	dgAnggota��$
��auto��6X      AutoGenerateColumns .   �� SelectedIndex$ 0��6�   $��10,0,0,0q�6�   ��6@   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Id Anggota��6L      Width5  /System.Windows.Controls.DataGridLengthConverter$ 90 6`   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6-   �� *
id_anggota+6`     5      $
 Nama��6N   $ 90 6\   	 6-   �� *nama_anggota+6\     5      $ No. Telepon��6Q   $ 90 6f   	 6-   �� *telepon_anggota+6f     5      $ Alamat��6P   $ 90 6`   	 6-   �� *alamat_anggota+6`     5      $ Jenis Kelamin��6S   $ 90 6j   	 6-   �� *jenis_kel_anggota+6j     5      $ Tempat Lahir��6V   $ 90 6l   	 6-   �� *tempat_lahir_anggota+6l     5      $ Tanggal Lahir��6W   $ 90 6n   	 6-   �� *tanggal_lahir_anggota+6n     5      $ Tanggal Daftar��6P   $ 90 6h   	 6-   �� *tanggal_daftar+6h   5      5      5      �� 5   
   
�������
 J� Opacity$	
 0.7Q�6$   $��	0,0,0,355q�62   .+�5      �� -   5         ��Name$ 
btnKembali��5      $��50��6)   $��12(�64   
�������$ 10��6U   $ 10��6f   $��44��6v   .��5      �� $��..\\Image\93634.png��6   $��Center=�65   5      5      �� 5   
   -   5         ��Name$ lblAnggota1��5      $��Anggota��6%   
���   �$��26(�5       $��Medium"�6   $��Center=�62   $��262,10,262,355q�6O   �� 5!   
   -   5        $ btnDaftarAnggota��5!      $��Daftar Anggota��6+   $��Center=�6D   $��10,102,674,0q�6a   $	��Top=�6w   $	��108��6�   
����  �$��12(�6�   $
��Bold"�6�   
������� J� RenderTransformOrigin$ -0.287,0.55&�6�   6  �� 5"   
   -   5        $ btnInputAnggota��5"      $��Input Anggota��6*   $��Center=�6B   $��118,102,566,0q�6_   $	��Top=�6v   $	��108��6�   
����  �$��12(�6�   $
��Bold"�6�   
�������$ 	1.963,0.3&�6�   6  5%      5&      