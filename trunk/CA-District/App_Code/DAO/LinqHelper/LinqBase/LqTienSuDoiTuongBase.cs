




/*
'===============================================================================
'  LinqHelper.DAO.TienSuDoiTuongBase
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.DAO
{
	public class LqTienSuDoiTuongBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTienSuDoiTuongBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqTienSuDoiTuongEntity obj)
		{
			provider.GetTable<LqTienSuDoiTuongEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqTienSuDoiTuongEntity _obj)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqTienSuDoiTuongEntity tmp = q.First<LqTienSuDoiTuongEntity>();
			
			tmp.IdDoiTuong = _obj.IdDoiTuong;
			tmp.IdXuLyHanhChinh = _obj.IdXuLyHanhChinh;
			tmp.IdHanhVi = _obj.IdHanhVi;
			tmp.SoQuyDinh = _obj.SoQuyDinh;
			tmp.NgayQuyDinh = _obj.NgayQuyDinh;
			tmp.NgayBatDau = _obj.NgayBatDau;
			tmp.NgayKetThuc = _obj.NgayKetThuc;
			tmp.MucPhatTien = _obj.MucPhatTien;
			tmp.SoXl135 = _obj.SoXl135;
			tmp.NgayXl135 = _obj.NgayXl135;
			tmp.IdCscb = _obj.IdCscb;
			tmp.NgayTron = _obj.NgayTron;
			tmp.NgayBatLai = _obj.NgayBatLai;
			tmp.SoQuyDinhTruyTim = _obj.SoQuyDinhTruyTim;
			tmp.NgayQuyDinhTruyTim = _obj.NgayQuyDinhTruyTim;
			tmp.SoQuyDinhHoaNhap = _obj.SoQuyDinhHoaNhap;
			tmp.NgayQuyDinhHoaNhap = _obj.NgayQuyDinhHoaNhap;
			tmp.NgayVeDiaPhuong = _obj.NgayVeDiaPhuong;
			tmp.SoQuyDinhTaiNghien = _obj.SoQuyDinhTaiNghien;
			tmp.NgayQuyDinhTaiNghien = _obj.NgayQuyDinhTaiNghien;
			tmp.IdQuanLy = _obj.IdQuanLy;
			tmp.TongHop = _obj.TongHop;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.MaTp = _obj.MaTp;
			tmp.LoaiDanhMuc = _obj.LoaiDanhMuc;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqTienSuDoiTuongEntity obj)
		{
			provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDoiTuong(Guid IdDoiTuong)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.IdDoiTuong == IdDoiTuong
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdXuLyHanhChinh(Guid IdXuLyHanhChinh)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.IdXuLyHanhChinh.Value == IdXuLyHanhChinh
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdHanhVi(Guid IdHanhVi)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.IdHanhVi.Value == IdHanhVi
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoQuyDinh(string SoQuyDinh)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.SoQuyDinh == SoQuyDinh
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayQuyDinh(DateTime NgayQuyDinh)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.NgayQuyDinh.Value == NgayQuyDinh
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayBatDau(DateTime NgayBatDau)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.NgayBatDau.Value == NgayBatDau
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayKetThuc(DateTime NgayKetThuc)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.NgayKetThuc.Value == NgayKetThuc
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMucPhatTien(decimal MucPhatTien)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.MucPhatTien.Value == MucPhatTien
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoXl135(string SoXl135)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.SoXl135 == SoXl135
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayXl135(DateTime NgayXl135)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.NgayXl135.Value == NgayXl135
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdCscb(Guid IdCscb)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.IdCscb.Value == IdCscb
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTron(DateTime NgayTron)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.NgayTron.Value == NgayTron
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayBatLai(DateTime NgayBatLai)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.NgayBatLai.Value == NgayBatLai
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoQuyDinhTruyTim(string SoQuyDinhTruyTim)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.SoQuyDinhTruyTim == SoQuyDinhTruyTim
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayQuyDinhTruyTim(DateTime NgayQuyDinhTruyTim)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.NgayQuyDinhTruyTim.Value == NgayQuyDinhTruyTim
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoQuyDinhHoaNhap(string SoQuyDinhHoaNhap)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.SoQuyDinhHoaNhap == SoQuyDinhHoaNhap
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayQuyDinhHoaNhap(DateTime NgayQuyDinhHoaNhap)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.NgayQuyDinhHoaNhap.Value == NgayQuyDinhHoaNhap
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayVeDiaPhuong(DateTime NgayVeDiaPhuong)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.NgayVeDiaPhuong.Value == NgayVeDiaPhuong
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoQuyDinhTaiNghien(string SoQuyDinhTaiNghien)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.SoQuyDinhTaiNghien == SoQuyDinhTaiNghien
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayQuyDinhTaiNghien(DateTime NgayQuyDinhTaiNghien)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.NgayQuyDinhTaiNghien.Value == NgayQuyDinhTaiNghien
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdQuanLy(Guid IdQuanLy)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.IdQuanLy.Value == IdQuanLy
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTongHop(string TongHop)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.TongHop == TongHop
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqTienSuDoiTuongEntity ob = (LqTienSuDoiTuongEntity)q.First<LqTienSuDoiTuongEntity>();
            provider.GetTable<LqTienSuDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqTienSuDoiTuongEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqTienSuDoiTuongEntity>();
		}

		public List<LqTienSuDoiTuongEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByIdDoiTuong(Guid IdDoiTuong)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.IdDoiTuong == IdDoiTuong
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByIdXuLyHanhChinh(Guid IdXuLyHanhChinh)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.IdXuLyHanhChinh.Value == IdXuLyHanhChinh
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByIdHanhVi(Guid IdHanhVi)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.IdHanhVi.Value == IdHanhVi
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectBySoQuyDinh(string SoQuyDinh)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.SoQuyDinh == SoQuyDinh
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByNgayQuyDinh(DateTime NgayQuyDinh)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.NgayQuyDinh.Value == NgayQuyDinh
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByNgayBatDau(DateTime NgayBatDau)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.NgayBatDau.Value == NgayBatDau
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByNgayKetThuc(DateTime NgayKetThuc)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.NgayKetThuc.Value == NgayKetThuc
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByMucPhatTien(decimal MucPhatTien)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.MucPhatTien.Value == MucPhatTien
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectBySoXl135(string SoXl135)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.SoXl135 == SoXl135
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByNgayXl135(DateTime NgayXl135)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.NgayXl135.Value == NgayXl135
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByIdCscb(Guid IdCscb)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.IdCscb.Value == IdCscb
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByNgayTron(DateTime NgayTron)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.NgayTron.Value == NgayTron
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByNgayBatLai(DateTime NgayBatLai)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.NgayBatLai.Value == NgayBatLai
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectBySoQuyDinhTruyTim(string SoQuyDinhTruyTim)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.SoQuyDinhTruyTim == SoQuyDinhTruyTim
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByNgayQuyDinhTruyTim(DateTime NgayQuyDinhTruyTim)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.NgayQuyDinhTruyTim.Value == NgayQuyDinhTruyTim
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectBySoQuyDinhHoaNhap(string SoQuyDinhHoaNhap)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.SoQuyDinhHoaNhap == SoQuyDinhHoaNhap
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByNgayQuyDinhHoaNhap(DateTime NgayQuyDinhHoaNhap)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.NgayQuyDinhHoaNhap.Value == NgayQuyDinhHoaNhap
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByNgayVeDiaPhuong(DateTime NgayVeDiaPhuong)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.NgayVeDiaPhuong.Value == NgayVeDiaPhuong
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectBySoQuyDinhTaiNghien(string SoQuyDinhTaiNghien)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.SoQuyDinhTaiNghien == SoQuyDinhTaiNghien
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByNgayQuyDinhTaiNghien(DateTime NgayQuyDinhTaiNghien)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.NgayQuyDinhTaiNghien.Value == NgayQuyDinhTaiNghien
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByIdQuanLy(Guid IdQuanLy)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.IdQuanLy.Value == IdQuanLy
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByTongHop(string TongHop)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.TongHop == TongHop
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		public List<LqTienSuDoiTuongEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqTienSuDoiTuongEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqTienSuDoiTuongEntity>();
		}
		
		
		

	}
}
