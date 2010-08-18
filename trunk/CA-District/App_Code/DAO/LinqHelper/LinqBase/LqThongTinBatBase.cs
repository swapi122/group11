




/*
'===============================================================================
'  LinqHelper.DAO.ThongTinBatBase
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
	public class LqThongTinBatBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqThongTinBatBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqThongTinBatEntity obj)
		{
			provider.GetTable<LqThongTinBatEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqThongTinBatEntity _obj)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqThongTinBatEntity tmp = q.First<LqThongTinBatEntity>();
			
			tmp.IdDoiTuong = _obj.IdDoiTuong;
			tmp.SoKhoiTo = _obj.SoKhoiTo;
			tmp.NgayKhoiTo = _obj.NgayKhoiTo;
			tmp.SoLenhBat = _obj.SoLenhBat;
			tmp.NgayRaLenhBat = _obj.NgayRaLenhBat;
			tmp.NgayBat = _obj.NgayBat;
			tmp.SoPhong = _obj.SoPhong;
			tmp.TinhChat = _obj.TinhChat;
			tmp.IdTruongHopBat = _obj.IdTruongHopBat;
			tmp.LenhTamGiu = _obj.LenhTamGiu;
			tmp.NgayTamGiu = _obj.NgayTamGiu;
			tmp.GiaHanTamGiu = _obj.GiaHanTamGiu;
			tmp.LenhTamGiam = _obj.LenhTamGiam;
			tmp.NgayTamGiam = _obj.NgayTamGiam;
			tmp.GiaHanTamGiam = _obj.GiaHanTamGiam;
			tmp.IdDieuKhoiTo = _obj.IdDieuKhoiTo;
			tmp.IdVuAn = _obj.IdVuAn;
			tmp.DoiTuongDungDau = _obj.DoiTuongDungDau;
			tmp.IdHinhThucXuLy = _obj.IdHinhThucXuLy;
			tmp.NgayXuLy = _obj.NgayXuLy;
			tmp.MucXuLy = _obj.MucXuLy;
			tmp.DonViThuLy = _obj.DonViThuLy;
			tmp.CanBoDieuTra = _obj.CanBoDieuTra;
			tmp.SoHoSo = _obj.SoHoSo;
			tmp.NgayLap = _obj.NgayLap;
			tmp.SoNopLuu = _obj.SoNopLuu;
			tmp.NgayLuu = _obj.NgayLuu;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.MaTp = _obj.MaTp;
			tmp.LoaiDanhMuc = _obj.LoaiDanhMuc;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqThongTinBatEntity obj)
		{
			provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDoiTuong(Guid IdDoiTuong)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.IdDoiTuong == IdDoiTuong
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoKhoiTo(string SoKhoiTo)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.SoKhoiTo == SoKhoiTo
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayKhoiTo(DateTime NgayKhoiTo)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.NgayKhoiTo.Value == NgayKhoiTo
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoLenhBat(string SoLenhBat)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.SoLenhBat == SoLenhBat
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayRaLenhBat(DateTime NgayRaLenhBat)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.NgayRaLenhBat.Value == NgayRaLenhBat
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayBat(DateTime NgayBat)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.NgayBat.Value == NgayBat
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoPhong(string SoPhong)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.SoPhong == SoPhong
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTinhChat(string TinhChat)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.TinhChat == TinhChat
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdTruongHopBat(Guid IdTruongHopBat)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.IdTruongHopBat.Value == IdTruongHopBat
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLenhTamGiu(string LenhTamGiu)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.LenhTamGiu == LenhTamGiu
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTamGiu(DateTime NgayTamGiu)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.NgayTamGiu.Value == NgayTamGiu
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGiaHanTamGiu(DateTime GiaHanTamGiu)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.GiaHanTamGiu.Value == GiaHanTamGiu
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLenhTamGiam(string LenhTamGiam)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.LenhTamGiam == LenhTamGiam
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTamGiam(DateTime NgayTamGiam)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.NgayTamGiam.Value == NgayTamGiam
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGiaHanTamGiam(DateTime GiaHanTamGiam)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.GiaHanTamGiam.Value == GiaHanTamGiam
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDieuKhoiTo(Guid IdDieuKhoiTo)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.IdDieuKhoiTo.Value == IdDieuKhoiTo
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdVuAn(Guid IdVuAn)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.IdVuAn.Value == IdVuAn
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByDoiTuongDungDau(string DoiTuongDungDau)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.DoiTuongDungDau == DoiTuongDungDau
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdHinhThucXuLy(Guid IdHinhThucXuLy)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.IdHinhThucXuLy.Value == IdHinhThucXuLy
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayXuLy(DateTime NgayXuLy)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.NgayXuLy.Value == NgayXuLy
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMucXuLy(string MucXuLy)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.MucXuLy == MucXuLy
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByDonViThuLy(string DonViThuLy)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.DonViThuLy == DonViThuLy
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByCanBoDieuTra(string CanBoDieuTra)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.CanBoDieuTra == CanBoDieuTra
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoHoSo(string SoHoSo)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.SoHoSo == SoHoSo
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayLap(DateTime NgayLap)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.NgayLap.Value == NgayLap
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoNopLuu(string SoNopLuu)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.SoNopLuu == SoNopLuu
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayLuu(DateTime NgayLuu)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.NgayLuu.Value == NgayLuu
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqThongTinBatEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqThongTinBatEntity ob = (LqThongTinBatEntity)q.First<LqThongTinBatEntity>();
            provider.GetTable<LqThongTinBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqThongTinBatEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqThongTinBatEntity>();
		}

		public List<LqThongTinBatEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByIdDoiTuong(Guid IdDoiTuong)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.IdDoiTuong == IdDoiTuong
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectBySoKhoiTo(string SoKhoiTo)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.SoKhoiTo == SoKhoiTo
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByNgayKhoiTo(DateTime NgayKhoiTo)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.NgayKhoiTo.Value == NgayKhoiTo
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectBySoLenhBat(string SoLenhBat)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.SoLenhBat == SoLenhBat
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByNgayRaLenhBat(DateTime NgayRaLenhBat)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.NgayRaLenhBat.Value == NgayRaLenhBat
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByNgayBat(DateTime NgayBat)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.NgayBat.Value == NgayBat
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectBySoPhong(string SoPhong)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.SoPhong == SoPhong
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByTinhChat(string TinhChat)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.TinhChat == TinhChat
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByIdTruongHopBat(Guid IdTruongHopBat)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.IdTruongHopBat.Value == IdTruongHopBat
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByLenhTamGiu(string LenhTamGiu)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.LenhTamGiu == LenhTamGiu
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByNgayTamGiu(DateTime NgayTamGiu)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.NgayTamGiu.Value == NgayTamGiu
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByGiaHanTamGiu(DateTime GiaHanTamGiu)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.GiaHanTamGiu.Value == GiaHanTamGiu
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByLenhTamGiam(string LenhTamGiam)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.LenhTamGiam == LenhTamGiam
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByNgayTamGiam(DateTime NgayTamGiam)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.NgayTamGiam.Value == NgayTamGiam
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByGiaHanTamGiam(DateTime GiaHanTamGiam)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.GiaHanTamGiam.Value == GiaHanTamGiam
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByIdDieuKhoiTo(Guid IdDieuKhoiTo)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.IdDieuKhoiTo.Value == IdDieuKhoiTo
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByIdVuAn(Guid IdVuAn)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.IdVuAn.Value == IdVuAn
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByDoiTuongDungDau(string DoiTuongDungDau)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.DoiTuongDungDau == DoiTuongDungDau
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByIdHinhThucXuLy(Guid IdHinhThucXuLy)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.IdHinhThucXuLy.Value == IdHinhThucXuLy
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByNgayXuLy(DateTime NgayXuLy)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.NgayXuLy.Value == NgayXuLy
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByMucXuLy(string MucXuLy)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.MucXuLy == MucXuLy
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByDonViThuLy(string DonViThuLy)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.DonViThuLy == DonViThuLy
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByCanBoDieuTra(string CanBoDieuTra)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.CanBoDieuTra == CanBoDieuTra
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectBySoHoSo(string SoHoSo)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.SoHoSo == SoHoSo
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByNgayLap(DateTime NgayLap)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.NgayLap.Value == NgayLap
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectBySoNopLuu(string SoNopLuu)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.SoNopLuu == SoNopLuu
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByNgayLuu(DateTime NgayLuu)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.NgayLuu.Value == NgayLuu
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		public List<LqThongTinBatEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqThongTinBatEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqThongTinBatEntity>();
		}
		
		
		

	}
}
