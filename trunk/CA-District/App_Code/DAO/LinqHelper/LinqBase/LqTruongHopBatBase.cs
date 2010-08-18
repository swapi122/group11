




/*
'===============================================================================
'  LinqHelper.DAO.TruongHopBatBase
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
	public class LqTruongHopBatBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTruongHopBatBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqTruongHopBatEntity obj)
		{
			provider.GetTable<LqTruongHopBatEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqTruongHopBatEntity _obj)
		{
			var q = from obj in provider.GetTable<LqTruongHopBatEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqTruongHopBatEntity tmp = q.First<LqTruongHopBatEntity>();
			
			tmp.TenTruongHopBat = _obj.TenTruongHopBat;
			tmp.IdMaCha = _obj.IdMaCha;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.MaTp = _obj.MaTp;
			tmp.GhiChu = _obj.GhiChu;
			tmp.LoaiDanhMuc = _obj.LoaiDanhMuc;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.NgayHetHan = _obj.NgayHetHan;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqTruongHopBatEntity obj)
		{
			provider.GetTable<LqTruongHopBatEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqTruongHopBatEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqTruongHopBatEntity ob = (LqTruongHopBatEntity)q.First<LqTruongHopBatEntity>();
            provider.GetTable<LqTruongHopBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenTruongHopBat(string TenTruongHopBat)
		{
			var q = from obj in provider.GetTable<LqTruongHopBatEntity>()
                    where obj.TenTruongHopBat == TenTruongHopBat
                    select obj;
					
            LqTruongHopBatEntity ob = (LqTruongHopBatEntity)q.First<LqTruongHopBatEntity>();
            provider.GetTable<LqTruongHopBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdMaCha(Guid IdMaCha)
		{
			var q = from obj in provider.GetTable<LqTruongHopBatEntity>()
                    where obj.IdMaCha.Value == IdMaCha
                    select obj;
					
            LqTruongHopBatEntity ob = (LqTruongHopBatEntity)q.First<LqTruongHopBatEntity>();
            provider.GetTable<LqTruongHopBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqTruongHopBatEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqTruongHopBatEntity ob = (LqTruongHopBatEntity)q.First<LqTruongHopBatEntity>();
            provider.GetTable<LqTruongHopBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqTruongHopBatEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqTruongHopBatEntity ob = (LqTruongHopBatEntity)q.First<LqTruongHopBatEntity>();
            provider.GetTable<LqTruongHopBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqTruongHopBatEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqTruongHopBatEntity ob = (LqTruongHopBatEntity)q.First<LqTruongHopBatEntity>();
            provider.GetTable<LqTruongHopBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqTruongHopBatEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqTruongHopBatEntity ob = (LqTruongHopBatEntity)q.First<LqTruongHopBatEntity>();
            provider.GetTable<LqTruongHopBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqTruongHopBatEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqTruongHopBatEntity ob = (LqTruongHopBatEntity)q.First<LqTruongHopBatEntity>();
            provider.GetTable<LqTruongHopBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqTruongHopBatEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqTruongHopBatEntity ob = (LqTruongHopBatEntity)q.First<LqTruongHopBatEntity>();
            provider.GetTable<LqTruongHopBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqTruongHopBatEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqTruongHopBatEntity ob = (LqTruongHopBatEntity)q.First<LqTruongHopBatEntity>();
            provider.GetTable<LqTruongHopBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqTruongHopBatEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqTruongHopBatEntity ob = (LqTruongHopBatEntity)q.First<LqTruongHopBatEntity>();
            provider.GetTable<LqTruongHopBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqTruongHopBatEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqTruongHopBatEntity ob = (LqTruongHopBatEntity)q.First<LqTruongHopBatEntity>();
            provider.GetTable<LqTruongHopBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqTruongHopBatEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqTruongHopBatEntity ob = (LqTruongHopBatEntity)q.First<LqTruongHopBatEntity>();
            provider.GetTable<LqTruongHopBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqTruongHopBatEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTruongHopBatEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqTruongHopBatEntity>();
		}

		public List<LqTruongHopBatEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqTruongHopBatEntity>()
                        select obj;
            return query.ToList<LqTruongHopBatEntity>();
		}
		
		
		public List<LqTruongHopBatEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTruongHopBatEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqTruongHopBatEntity>();
		}
		
		
		public List<LqTruongHopBatEntity> SelectByTenTruongHopBat(string TenTruongHopBat)
		{
			var query = from obj in provider.GetTable<LqTruongHopBatEntity>()
                        where obj.TenTruongHopBat == TenTruongHopBat
                        select obj;
            return query.ToList<LqTruongHopBatEntity>();
		}
		
		
		public List<LqTruongHopBatEntity> SelectByIdMaCha(Guid IdMaCha)
		{
			var query = from obj in provider.GetTable<LqTruongHopBatEntity>()
                        where obj.IdMaCha.Value == IdMaCha
                        select obj;
            return query.ToList<LqTruongHopBatEntity>();
		}
		
		
		public List<LqTruongHopBatEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqTruongHopBatEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqTruongHopBatEntity>();
		}
		
		
		public List<LqTruongHopBatEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqTruongHopBatEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqTruongHopBatEntity>();
		}
		
		
		public List<LqTruongHopBatEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqTruongHopBatEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqTruongHopBatEntity>();
		}
		
		
		public List<LqTruongHopBatEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqTruongHopBatEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqTruongHopBatEntity>();
		}
		
		
		public List<LqTruongHopBatEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqTruongHopBatEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqTruongHopBatEntity>();
		}
		
		
		public List<LqTruongHopBatEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqTruongHopBatEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqTruongHopBatEntity>();
		}
		
		
		public List<LqTruongHopBatEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqTruongHopBatEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqTruongHopBatEntity>();
		}
		
		
		public List<LqTruongHopBatEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqTruongHopBatEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqTruongHopBatEntity>();
		}
		
		
		public List<LqTruongHopBatEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqTruongHopBatEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqTruongHopBatEntity>();
		}
		
		
		public List<LqTruongHopBatEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqTruongHopBatEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqTruongHopBatEntity>();
		}
		
		
		

	}
}
