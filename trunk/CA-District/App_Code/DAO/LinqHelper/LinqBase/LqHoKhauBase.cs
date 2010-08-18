




/*
'===============================================================================
'  LinqHelper.DAO.HoKhauBase
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
	public class LqHoKhauBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqHoKhauBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqHoKhauEntity obj)
		{
			provider.GetTable<LqHoKhauEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqHoKhauEntity _obj)
		{
			var q = from obj in provider.GetTable<LqHoKhauEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqHoKhauEntity tmp = q.First<LqHoKhauEntity>();
			
			tmp.IdLoaiHoKhau = _obj.IdLoaiHoKhau;
			tmp.IdKiemDien = _obj.IdKiemDien;
			tmp.IdNuoc = _obj.IdNuoc;
			tmp.IdTinh = _obj.IdTinh;
			tmp.IdHuyen = _obj.IdHuyen;
			tmp.IdXa = _obj.IdXa;
			tmp.IdThon = _obj.IdThon;
			tmp.IdOkhuVuc = _obj.IdOkhuVuc;
			tmp.IdToDanPho = _obj.IdToDanPho;
			tmp.SoNha = _obj.SoNha;
			tmp.Duong = _obj.Duong;
			tmp.TongHopCacNoiCuNgu = _obj.TongHopCacNoiCuNgu;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.MaTp = _obj.MaTp;
			tmp.GhiChu = _obj.GhiChu;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.NgayHetHan = _obj.NgayHetHan;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqHoKhauEntity obj)
		{
			provider.GetTable<LqHoKhauEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqHoKhauEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqHoKhauEntity ob = (LqHoKhauEntity)q.First<LqHoKhauEntity>();
            provider.GetTable<LqHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdLoaiHoKhau(Guid IdLoaiHoKhau)
		{
			var q = from obj in provider.GetTable<LqHoKhauEntity>()
                    where obj.IdLoaiHoKhau.Value == IdLoaiHoKhau
                    select obj;
					
            LqHoKhauEntity ob = (LqHoKhauEntity)q.First<LqHoKhauEntity>();
            provider.GetTable<LqHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdKiemDien(Guid IdKiemDien)
		{
			var q = from obj in provider.GetTable<LqHoKhauEntity>()
                    where obj.IdKiemDien.Value == IdKiemDien
                    select obj;
					
            LqHoKhauEntity ob = (LqHoKhauEntity)q.First<LqHoKhauEntity>();
            provider.GetTable<LqHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNuoc(Guid IdNuoc)
		{
			var q = from obj in provider.GetTable<LqHoKhauEntity>()
                    where obj.IdNuoc.Value == IdNuoc
                    select obj;
					
            LqHoKhauEntity ob = (LqHoKhauEntity)q.First<LqHoKhauEntity>();
            provider.GetTable<LqHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdTinh(Guid IdTinh)
		{
			var q = from obj in provider.GetTable<LqHoKhauEntity>()
                    where obj.IdTinh.Value == IdTinh
                    select obj;
					
            LqHoKhauEntity ob = (LqHoKhauEntity)q.First<LqHoKhauEntity>();
            provider.GetTable<LqHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdHuyen(Guid IdHuyen)
		{
			var q = from obj in provider.GetTable<LqHoKhauEntity>()
                    where obj.IdHuyen.Value == IdHuyen
                    select obj;
					
            LqHoKhauEntity ob = (LqHoKhauEntity)q.First<LqHoKhauEntity>();
            provider.GetTable<LqHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdXa(Guid IdXa)
		{
			var q = from obj in provider.GetTable<LqHoKhauEntity>()
                    where obj.IdXa.Value == IdXa
                    select obj;
					
            LqHoKhauEntity ob = (LqHoKhauEntity)q.First<LqHoKhauEntity>();
            provider.GetTable<LqHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdThon(Guid IdThon)
		{
			var q = from obj in provider.GetTable<LqHoKhauEntity>()
                    where obj.IdThon.Value == IdThon
                    select obj;
					
            LqHoKhauEntity ob = (LqHoKhauEntity)q.First<LqHoKhauEntity>();
            provider.GetTable<LqHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdOkhuVuc(Guid IdOkhuVuc)
		{
			var q = from obj in provider.GetTable<LqHoKhauEntity>()
                    where obj.IdOkhuVuc.Value == IdOkhuVuc
                    select obj;
					
            LqHoKhauEntity ob = (LqHoKhauEntity)q.First<LqHoKhauEntity>();
            provider.GetTable<LqHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdToDanPho(Guid IdToDanPho)
		{
			var q = from obj in provider.GetTable<LqHoKhauEntity>()
                    where obj.IdToDanPho.Value == IdToDanPho
                    select obj;
					
            LqHoKhauEntity ob = (LqHoKhauEntity)q.First<LqHoKhauEntity>();
            provider.GetTable<LqHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoNha(string SoNha)
		{
			var q = from obj in provider.GetTable<LqHoKhauEntity>()
                    where obj.SoNha == SoNha
                    select obj;
					
            LqHoKhauEntity ob = (LqHoKhauEntity)q.First<LqHoKhauEntity>();
            provider.GetTable<LqHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByDuong(string Duong)
		{
			var q = from obj in provider.GetTable<LqHoKhauEntity>()
                    where obj.Duong == Duong
                    select obj;
					
            LqHoKhauEntity ob = (LqHoKhauEntity)q.First<LqHoKhauEntity>();
            provider.GetTable<LqHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTongHopCacNoiCuNgu(string TongHopCacNoiCuNgu)
		{
			var q = from obj in provider.GetTable<LqHoKhauEntity>()
                    where obj.TongHopCacNoiCuNgu == TongHopCacNoiCuNgu
                    select obj;
					
            LqHoKhauEntity ob = (LqHoKhauEntity)q.First<LqHoKhauEntity>();
            provider.GetTable<LqHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqHoKhauEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqHoKhauEntity ob = (LqHoKhauEntity)q.First<LqHoKhauEntity>();
            provider.GetTable<LqHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqHoKhauEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqHoKhauEntity ob = (LqHoKhauEntity)q.First<LqHoKhauEntity>();
            provider.GetTable<LqHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqHoKhauEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqHoKhauEntity ob = (LqHoKhauEntity)q.First<LqHoKhauEntity>();
            provider.GetTable<LqHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqHoKhauEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqHoKhauEntity ob = (LqHoKhauEntity)q.First<LqHoKhauEntity>();
            provider.GetTable<LqHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqHoKhauEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqHoKhauEntity ob = (LqHoKhauEntity)q.First<LqHoKhauEntity>();
            provider.GetTable<LqHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqHoKhauEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqHoKhauEntity ob = (LqHoKhauEntity)q.First<LqHoKhauEntity>();
            provider.GetTable<LqHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqHoKhauEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqHoKhauEntity ob = (LqHoKhauEntity)q.First<LqHoKhauEntity>();
            provider.GetTable<LqHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqHoKhauEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqHoKhauEntity ob = (LqHoKhauEntity)q.First<LqHoKhauEntity>();
            provider.GetTable<LqHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqHoKhauEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqHoKhauEntity ob = (LqHoKhauEntity)q.First<LqHoKhauEntity>();
            provider.GetTable<LqHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqHoKhauEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqHoKhauEntity>();
		}

		public List<LqHoKhauEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        select obj;
            return query.ToList<LqHoKhauEntity>();
		}
		
		
		public List<LqHoKhauEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqHoKhauEntity>();
		}
		
		
		public List<LqHoKhauEntity> SelectByIdLoaiHoKhau(Guid IdLoaiHoKhau)
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        where obj.IdLoaiHoKhau.Value == IdLoaiHoKhau
                        select obj;
            return query.ToList<LqHoKhauEntity>();
		}
		
		
		public List<LqHoKhauEntity> SelectByIdKiemDien(Guid IdKiemDien)
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        where obj.IdKiemDien.Value == IdKiemDien
                        select obj;
            return query.ToList<LqHoKhauEntity>();
		}
		
		
		public List<LqHoKhauEntity> SelectByIdNuoc(Guid IdNuoc)
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        where obj.IdNuoc.Value == IdNuoc
                        select obj;
            return query.ToList<LqHoKhauEntity>();
		}
		
		
		public List<LqHoKhauEntity> SelectByIdTinh(Guid IdTinh)
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        where obj.IdTinh.Value == IdTinh
                        select obj;
            return query.ToList<LqHoKhauEntity>();
		}
		
		
		public List<LqHoKhauEntity> SelectByIdHuyen(Guid IdHuyen)
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        where obj.IdHuyen.Value == IdHuyen
                        select obj;
            return query.ToList<LqHoKhauEntity>();
		}
		
		
		public List<LqHoKhauEntity> SelectByIdXa(Guid IdXa)
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        where obj.IdXa.Value == IdXa
                        select obj;
            return query.ToList<LqHoKhauEntity>();
		}
		
		
		public List<LqHoKhauEntity> SelectByIdThon(Guid IdThon)
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        where obj.IdThon.Value == IdThon
                        select obj;
            return query.ToList<LqHoKhauEntity>();
		}
		
		
		public List<LqHoKhauEntity> SelectByIdOkhuVuc(Guid IdOkhuVuc)
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        where obj.IdOkhuVuc.Value == IdOkhuVuc
                        select obj;
            return query.ToList<LqHoKhauEntity>();
		}
		
		
		public List<LqHoKhauEntity> SelectByIdToDanPho(Guid IdToDanPho)
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        where obj.IdToDanPho.Value == IdToDanPho
                        select obj;
            return query.ToList<LqHoKhauEntity>();
		}
		
		
		public List<LqHoKhauEntity> SelectBySoNha(string SoNha)
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        where obj.SoNha == SoNha
                        select obj;
            return query.ToList<LqHoKhauEntity>();
		}
		
		
		public List<LqHoKhauEntity> SelectByDuong(string Duong)
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        where obj.Duong == Duong
                        select obj;
            return query.ToList<LqHoKhauEntity>();
		}
		
		
		public List<LqHoKhauEntity> SelectByTongHopCacNoiCuNgu(string TongHopCacNoiCuNgu)
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        where obj.TongHopCacNoiCuNgu == TongHopCacNoiCuNgu
                        select obj;
            return query.ToList<LqHoKhauEntity>();
		}
		
		
		public List<LqHoKhauEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqHoKhauEntity>();
		}
		
		
		public List<LqHoKhauEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqHoKhauEntity>();
		}
		
		
		public List<LqHoKhauEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqHoKhauEntity>();
		}
		
		
		public List<LqHoKhauEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqHoKhauEntity>();
		}
		
		
		public List<LqHoKhauEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqHoKhauEntity>();
		}
		
		
		public List<LqHoKhauEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqHoKhauEntity>();
		}
		
		
		public List<LqHoKhauEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqHoKhauEntity>();
		}
		
		
		public List<LqHoKhauEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqHoKhauEntity>();
		}
		
		
		public List<LqHoKhauEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqHoKhauEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqHoKhauEntity>();
		}
		
		
		

	}
}
