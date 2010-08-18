




/*
'===============================================================================
'  LinqHelper.DAO.NuocBase
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
	public class LqNuocBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNuocBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqNuocEntity obj)
		{
			provider.GetTable<LqNuocEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqNuocEntity _obj)
		{
			var q = from obj in provider.GetTable<LqNuocEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqNuocEntity tmp = q.First<LqNuocEntity>();
			
			tmp.TenNuoc = _obj.TenNuoc;
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
		
		public void Delete(LqNuocEntity obj)
		{
			provider.GetTable<LqNuocEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqNuocEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqNuocEntity ob = (LqNuocEntity)q.First<LqNuocEntity>();
            provider.GetTable<LqNuocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenNuoc(string TenNuoc)
		{
			var q = from obj in provider.GetTable<LqNuocEntity>()
                    where obj.TenNuoc == TenNuoc
                    select obj;
					
            LqNuocEntity ob = (LqNuocEntity)q.First<LqNuocEntity>();
            provider.GetTable<LqNuocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqNuocEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqNuocEntity ob = (LqNuocEntity)q.First<LqNuocEntity>();
            provider.GetTable<LqNuocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqNuocEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqNuocEntity ob = (LqNuocEntity)q.First<LqNuocEntity>();
            provider.GetTable<LqNuocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqNuocEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqNuocEntity ob = (LqNuocEntity)q.First<LqNuocEntity>();
            provider.GetTable<LqNuocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqNuocEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqNuocEntity ob = (LqNuocEntity)q.First<LqNuocEntity>();
            provider.GetTable<LqNuocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqNuocEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqNuocEntity ob = (LqNuocEntity)q.First<LqNuocEntity>();
            provider.GetTable<LqNuocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqNuocEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqNuocEntity ob = (LqNuocEntity)q.First<LqNuocEntity>();
            provider.GetTable<LqNuocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqNuocEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqNuocEntity ob = (LqNuocEntity)q.First<LqNuocEntity>();
            provider.GetTable<LqNuocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqNuocEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqNuocEntity ob = (LqNuocEntity)q.First<LqNuocEntity>();
            provider.GetTable<LqNuocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqNuocEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqNuocEntity ob = (LqNuocEntity)q.First<LqNuocEntity>();
            provider.GetTable<LqNuocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqNuocEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqNuocEntity ob = (LqNuocEntity)q.First<LqNuocEntity>();
            provider.GetTable<LqNuocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqNuocEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqNuocEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqNuocEntity>();
		}

		public List<LqNuocEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqNuocEntity>()
                        select obj;
            return query.ToList<LqNuocEntity>();
		}
		
		
		public List<LqNuocEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqNuocEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqNuocEntity>();
		}
		
		
		public List<LqNuocEntity> SelectByTenNuoc(string TenNuoc)
		{
			var query = from obj in provider.GetTable<LqNuocEntity>()
                        where obj.TenNuoc == TenNuoc
                        select obj;
            return query.ToList<LqNuocEntity>();
		}
		
		
		public List<LqNuocEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqNuocEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqNuocEntity>();
		}
		
		
		public List<LqNuocEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqNuocEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqNuocEntity>();
		}
		
		
		public List<LqNuocEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqNuocEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqNuocEntity>();
		}
		
		
		public List<LqNuocEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqNuocEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqNuocEntity>();
		}
		
		
		public List<LqNuocEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqNuocEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqNuocEntity>();
		}
		
		
		public List<LqNuocEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqNuocEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqNuocEntity>();
		}
		
		
		public List<LqNuocEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqNuocEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqNuocEntity>();
		}
		
		
		public List<LqNuocEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqNuocEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqNuocEntity>();
		}
		
		
		public List<LqNuocEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqNuocEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqNuocEntity>();
		}
		
		
		public List<LqNuocEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqNuocEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqNuocEntity>();
		}
		
		
		

	}
}
