﻿using QuanLiKhachSan.Model;
using QuanLiKhachSan.Model.MappingClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLiKhachSan.ViewModel
{
    public class PopUpDangKiThongBaoViewModel : BaseViewModel
    {
        public string myname
        {
            get; set;

        }
        public ICommand XoaThongBaoCommand { get; set; }
        public ICommand DangKiThongBaoCommand { get; set; }



        private BindingList<THEDANGKI> _dsHashTag;
        public BindingList<THEDANGKI> dsHashTag
        {
            get => _dsHashTag; set
            {
                OnPropertyChanged(ref _dsHashTag, value);
            }
        }

        private BindingList<THEDANGKI> _dsDaDangKi;
        public BindingList<THEDANGKI> dsDaDangKi
        {
            get => _dsDaDangKi; set
            {
                OnPropertyChanged(ref _dsDaDangKi, value);
            }
        }

        THEDANGKI _HasTagChon;
        public THEDANGKI HasTagChon { get => _HasTagChon; set { OnPropertyChanged(ref _HasTagChon, value); } }

        public PopUpDangKiThongBaoViewModel()
        {
            BindingList<HASTAG> listHashtag = DatabaseQueryTN.danhSachHashtag();

            MappingManager mappingManager2 = new MappingManager();
            mappingManager2.AddRule(new string[] { "HastagID" }, new string[] { "ID" }, new ClassCopyOneToOne());
            mappingManager2.AddRule(new string[] { "Name" }, new string[] { "Name" }, new ClassCopyOneToOne());
            dsHashTag = BusinessModel.ChuyenDoiDanhSach<HASTAG, THEDANGKI>(listHashtag, mappingManager2);

            //Danh sách đã đăng kí lấy từ CSDL
            dsDaDangKi = new BindingList<THEDANGKI>();
            dsDaDangKi.Add(dsHashTag[0]);
            dsDaDangKi.Add(dsHashTag[3]);


            DangKiThongBaoCommand = new RelayCommand<HASTAG>((p) => { return true; }, (p) =>
            {
                //Kiểm tra đã đăng kí rồi thì hiện thông báo
                if (dsDaDangKi.Contains(HasTagChon))
                {
                    MessageBox.Show("Bạn đã đăng kí thông báo  này.");

                }
                else
                {
                    dsDaDangKi.Add(HasTagChon);
                }
            });

            XoaThongBaoCommand = new RelayCommand<THEDANGKI>((p) => { return true; }, (p) =>
            {
                dsDaDangKi.Remove(p);
            });

        }
    }
}