   M S B A M L   `   `   `  ����E  APerpusDong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PerpusDong.ViewPerpusDong.View  5   	   *    $PerpusDong.View.DaftarPeminjamanPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PerpusDong.View     5   	     � Title$  DaftarPeminjamanPage��5   	   $	��450��6&   $	��800��63   
����d�.��5	      � .+�5   
   �� 
�������$��10,122,10,10q�6$   .+�5      �� $��10,10,10,10q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgDaftarPeminjaman��5      dgDaftarPeminjaman��$
��auto��6j      AutoGenerateColumns .   �� SelectedIndex$ 0��6�   ��6R   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Kode Pinjam��6K      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6`   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *	kd_pinjam+6`     5      $ 
Id Anggota��6L   $	 100 6`    6-   �� *
id_anggota+6`     5      $ Nama Anggota��6N   $	 100 6d    6-   �� *nama_anggota+6d     5      $ 	Kode Buku��6I   $ 80 6\    6-   �� *	kd_buku+6\     5      $ 	Nama Buku��6K   $ 80 6^    6-   �� *	nama_buku+6^     5      $ Tanggal Pinjam��6P   $	 100 6h    6-   �� *tanggal_pinjam+6h     5      $ Tanggal Kembali��6Q   $	 100 6j    6-   �� *tanggal_kembali+6j     5      $ Status��6O   $ 80 6_    6-   �� *status_pinjam+6_   5      5      5      �� 5   
   
������� J� Opacity$	 0.7Q�6$   $��	0,0,0,355q�62   .+�5      �� -   5        	 ��Name$	 
btnKembali��5      $��50��6)   $��12(�64   
�������
 �� Left$
 10��6U   
 �� Top$ 10��6f   $��44��6v   .��5      �� $��..\\Image\93634.png��6   $��Center=�65   5      5      �� 5    
   -   5         ��Name$ lblPeminjaman1��5       $��
Peminjaman��6(   
���   �$��26(�5!      $��Medium"�6   $��Center=�62   $��262,10,262,355q�6O   �� 5"   
   -   5        $	 btnDaftarPeminjaman��5"      $��Daftar Peminjaman��6.   $��Center=�6J   $��10,102,662,0q�6g   $	��Top=�6}   $	��120��6�   
����  �$��12(�6�   $
��Bold"�6�   
�������6�   �� 5#   
   -   5        $	 btnInputPeminjaman��5#      $��Input Peminjaman��6-   $��Center=�6H   $��130,102,542,0q�6e   $	��Top=�6|   $	��120��6�   
����  �$��12(�6�   $
��Bold"�6�   
�������6�   �� 5$   
   -   5        $	 btnInputPengembalian��5$      $��Input Pengembalian��6/   $��Center=�6L   $��250,102,422,0q�6i   $	��Top=�6�   $	��120��6�   
����  �$��12(�6�   $
��Bold"�6�   
�������6�   5%      5&      