




/*
'===============================================================================
'  LinqHelper.DAO.NguonPhatHienBase
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
	public class LqNguonPhatHienBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNguonPhatHienBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqNguonPhatHienEntity obj)
		{
			provider.GetTable<LqNguonPhatHienEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqNguonPhatHienEntity _obj)
		{
			var q = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqNguonPhatHienEntity tmp = q.First<LqNguonPhatHienEntity>();
			
			tmp.TenNguonPhatHien = _obj.TenNguonPhatHien;
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
		
		public void Delete(LqNguonPhatHienEntity obj)
		{
			provider.GetTable<LqNguonPhatHienEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqNguonPhatHienEntity ob = (LqNguonPhatHienEntity)q.First<LqNguonPhatHienEntity>();
            provider.GetTable<LqNguonPhatHienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenNguonPhatHien(string TenNguonPhatHien)
		{
			var q = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                    where obj.TenNguonPhatHien == TenNguonPhatHien
                    select obj;
					
            LqNguonPhatHienEntity ob = (LqNguonPhatHienEntity)q.First<LqNguonPhatHienEntity>();
            provider.GetTable<LqNguonPhatHienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdMaCha(Guid IdMaCha)
		{
			var q = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                    where obj.IdMaCha.Value == IdMaCha
                    select obj;
					
            LqNguonPhatHienEntity ob = (LqNguonPhatHienEntity)q.First<LqNguonPhatHienEntity>();
            provider.GetTable<LqNguonPhatHienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqNguonPhatHienEntity ob = (LqNguonPhatHienEntity)q.First<LqNguonPhatHienEntity>();
            provider.GetTable<LqNguonPhatHienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqNguonPhatHienEntity ob = (LqNguonPhatHienEntity)q.First<LqNguonPhatHienEntity>();
            provider.GetTable<LqNguonPhatHienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqNguonPhatHienEntity ob = (LqNguonPhatHienEntity)q.First<LqNguonPhatHienEntity>();
            provider.GetTable<LqNguonPhatHienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqNguonPhatHienEntity ob = (LqNguonPhatHienEntity)q.First<LqNguonPhatHienEntity>();
            provider.GetTable<LqNguonPhatHienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqNguonPhatHienEntity ob = (LqNguonPhatHienEntity)q.First<LqNguonPhatHienEntity>();
            provider.GetTable<LqNguonPhatHienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqNguonPhatHienEntity ob = (LqNguonPhatHienEntity)q.First<LqNguonPhatHienEntity>();
            provider.GetTable<LqNguonPhatHienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqNguonPhatHienEntity ob = (LqNguonPhatHienEntity)q.First<LqNguonPhatHienEntity>();
            provider.GetTable<LqNguonPhatHienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqNguonPhatHienEntity ob = (LqNguonPhatHienEntity)q.First<LqNguonPhatHienEntity>();
            provider.GetTable<LqNguonPhatHienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqNguonPhatHienEntity ob = (LqNguonPhatHienEntity)q.First<LqNguonPhatHienEntity>();
            provider.GetTable<LqNguonPhatHienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqNguonPhatHienEntity ob = (LqNguonPhatHienEntity)q.First<LqNguonPhatHienEntity>();
            provider.GetTable<LqNguonPhatHienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqNguonPhatHienEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqNguonPhatHienEntity>();
		}

		public List<LqNguonPhatHienEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                        select obj;
            return query.ToList<LqNguonPhatHienEntity>();
		}
		
		
		public List<LqNguonPhatHienEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqNguonPhatHienEntity>();
		}
		
		
		public List<LqNguonPhatHienEntity> SelectByTenNguonPhatHien(string TenNguonPhatHien)
		{
			var query = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                        where obj.TenNguonPhatHien == TenNguonPhatHien
                        select obj;
            return query.ToList<LqNguonPhatHienEntity>();
		}
		
		
		public List<LqNguonPhatHienEntity> SelectByIdMaCha(Guid IdMaCha)
		{
			var query = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                        where obj.IdMaCha.Value == IdMaCha
                        select obj;
            return query.ToList<LqNguonPhatHienEntity>();
		}
		
		
		public List<LqNguonPhatHienEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqNguonPhatHienEntity>();
		}
		
		
		public List<LqNguonPhatHienEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqNguonPhatHienEntity>();
		}
		
		
		public List<LqNguonPhatHienEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqNguonPhatHienEntity>();
		}
		
		
		public List<LqNguonPhatHienEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqNguonPhatHienEntity>();
		}
		
		
		public List<LqNguonPhatHienEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqNguonPhatHienEntity>();
		}
		
		
		public List<LqNguonPhatHienEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqNguonPhatHienEntity>();
		}
		
		
		public List<LqNguonPhatHienEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqNguonPhatHienEntity>();
		}
		
		
		public List<LqNguonPhatHienEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqNguonPhatHienEntity>();
		}
		
		
		public List<LqNguonPhatHienEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqNguonPhatHienEntity>();
		}
		
		
		public List<LqNguonPhatHienEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqNguonPhatHienEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqNguonPhatHienEntity>();
		}
		
		
		

	}
}
