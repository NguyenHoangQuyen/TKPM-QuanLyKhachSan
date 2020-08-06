﻿using QuanLiKhachSan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLiKhachSan.ViewModel
{
    public class LeTanDatPhongViewModel : BaseViewModel
    {
        private object _checkin;
        public object CheckinContext { get => _checkin; set => OnPropertyChanged(ref _checkin, value); }
        private int _slPhong;
        public int SlPhong { get => _slPhong; set => OnPropertyChanged(ref _slPhong, value); }

        private int _slPhongTrong;
        public int SlPhongTrong { get => _slPhongTrong; set => OnPropertyChanged(ref _slPhongTrong, value); }

        private int _slPhongDangThue;
        public int SlPhongDangThue { get => _slPhongDangThue; set => OnPropertyChanged(ref _slPhongDangThue, value); }


        private int _tenPhongItem;
        public int TenPhongItem
        {
            get => _tenPhongItem;
            set => OnPropertyChanged(ref _tenPhongItem, value);
        }

        private List<PHONG> _dsPhong;
        public List<PHONG> DSPhong { get => _dsPhong; set => OnPropertyChanged(ref _dsPhong, value); }

        private PHONG _phongChon;
        public PHONG PhongChon { get => _phongChon; set { OnPropertyChanged(ref _phongChon, value); } }

        public ICommand PhongChonCommand { get; set; }
        public ICommand troVeCommand { get; set; }


        //*************************************************************************
        public LeTanDatPhongViewModel()
        {
            DSPhong = DatabaseQuery.danhSachPhong();
            //***Su dụng listPhongTT thay cho DSPhong

            //KHi click vao 1 phong
            PhongChonCommand = new RelayCommand<ListView>((p) => { return true; }, (p) =>
               {
                   CheckinContext = new LeTanCheckInViewModel(PhongChon.PhongID);
                   FrameworkElement parent = p;
                   while (parent.Parent != null)
                   {
                       parent = parent.Parent as FrameworkElement;
                   }
                   var uc = parent as UserControl;
                   hienManHinhCheckIn(uc);
               }
            );

            //button trở về click
            troVeCommand = new RelayCommand<ListView>((p) => { return true; }, (p) =>
            {
                FrameworkElement parent = p;
                while (parent.Parent != null)
                {
                    parent = parent.Parent as FrameworkElement;
                }
                var uc = parent as UserControl;
                hienManHinhQuanLiTinhTrang(uc);
            });
        }
        void hienManHinhQuanLiTinhTrang(UserControl uc)
        {
            var stack = uc.FindName("QuanLiPhong") as StackPanel;
            stack.Visibility = Visibility.Visible;
            var btn = uc.FindName("btn_TroVe") as Button;
            btn.Visibility = Visibility.Collapsed;
            var ucCheckIn = uc.FindName("CheckIn") as ContentControl;
            ucCheckIn.Visibility = Visibility.Collapsed;
        }

        void hienManHinhCheckIn(UserControl uc)
        {
            var stack = uc.FindName("QuanLiPhong") as StackPanel;
            stack.Visibility = Visibility.Collapsed;
            var btn = uc.FindName("btn_TroVe") as Button;
            btn.Visibility = Visibility.Visible;
            var ucCheckIn = uc.FindName("CheckIn") as ContentControl;
            ucCheckIn.Visibility = Visibility.Visible;
        }
    }
}
