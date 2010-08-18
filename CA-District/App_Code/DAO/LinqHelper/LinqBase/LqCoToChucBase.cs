




/*
'===============================================================================
'  LinqHelper.DAO.CoToChucBase
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
	public class LqCoToChucBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqCoToChucBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqCoToChucEntity obj)
		{
			provider.GetTable<LqCoToChucEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqCoToChucEntity _obj)
		{
			var q = from obj in provider.GetTable<LqCoToChucEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqCoToChucEntity tmp = q.First<LqCoToChucEntity>();
			
			tmp.TenCoToChuc = _obj.TenCoToChuc;
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
		
		public void Delete(LqCoToChucEntity obj)
		{
			provider.GetTable<LqCoToChucEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqCoToChucEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqCoToChucEntity ob = (LqCoToChucEntity)q.First<LqCoToChucEntity>();
            provider.GetTable<LqCoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenCoToChuc(string TenCoToChuc)
		{
			var q = from obj in provider.GetTable<LqCoToChucEntity>()
                    where obj.TenCoToChuc == TenCoToChuc
                    select obj;
					
            LqCoToChucEntity ob = (LqCoToChucEntity)q.First<LqCoToChucEntity>();
            provider.GetTable<LqCoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqCoToChucEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqCoToChucEntity ob = (LqCoToChucEntity)q.First<LqCoToChucEntity>();
            provider.GetTable<LqCoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqCoToChucEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqCoToChucEntity ob = (LqCoToChucEntity)q.First<LqCoToChucEntity>();
            provider.GetTable<LqCoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqCoToChucEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqCoToChucEntity ob = (LqCoToChucEntity)q.First<LqCoToChucEntity>();
            provider.GetTable<LqCoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqCoToChucEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqCoToChucEntity ob = (LqCoToChucEntity)q.First<LqCoToChucEntity>();
            provider.GetTable<LqCoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqCoToChucEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqCoToChucEntity ob = (LqCoToChucEntity)q.First<LqCoToChucEntity>();
            provider.GetTable<LqCoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqCoToChucEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqCoToChucEntity ob = (LqCoToChucEntity)q.First<LqCoToChucEntity>();
            provider.GetTable<LqCoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqCoToChucEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqCoToChucEntity ob = (LqCoToChucEntity)q.First<LqCoToChucEntity>();
            provider.GetTable<LqCoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqCoToChucEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqCoToChucEntity ob = (LqCoToChucEntity)q.First<LqCoToChucEntity>();
            provider.GetTable<LqCoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqCoToChucEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqCoToChucEntity ob = (LqCoToChucEntity)q.First<LqCoToChucEntity>();
            provider.GetTable<LqCoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqCoToChucEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqCoToChucEntity ob = (LqCoToChucEntity)q.First<LqCoToChucEntity>();
            provider.GetTable<LqCoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqCoToChucEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqCoToChucEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqCoToChucEntity>();
		}

		public List<LqCoToChucEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqCoToChucEntity>()
                        select obj;
            return query.ToList<LqCoToChucEntity>();
		}
		
		
		public List<LqCoToChucEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqCoToChucEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqCoToChucEntity>();
		}
		
		
		public List<LqCoToChucEntity> SelectByTenCoToChuc(string TenCoToChuc)
		{
			var query = from obj in provider.GetTable<LqCoToChucEntity>()
                        where obj.TenCoToChuc == TenCoToChuc
                        select obj;
            return query.ToList<LqCoToChucEntity>();
		}
		
		
		public List<LqCoToChucEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqCoToChucEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqCoToChucEntity>();
		}
		
		
		public List<LqCoToChucEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqCoToChucEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqCoToChucEntity>();
		}
		
		
		public List<LqCoToChucEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqCoToChucEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqCoToChucEntity>();
		}
		
		
		public List<LqCoToChucEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqCoToChucEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqCoToChucEntity>();
		}
		
		
		public List<LqCoToChucEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqCoToChucEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqCoToChucEntity>();
		}
		
		
		public List<LqCoToChucEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqCoToChucEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqCoToChucEntity>();
		}
		
		
		public List<LqCoToChucEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqCoToChucEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqCoToChucEntity>();
		}
		
		
		public List<LqCoToChucEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqCoToChucEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqCoToChucEntity>();
		}
		
		
		public List<LqCoToChucEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqCoToChucEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqCoToChucEntity>();
		}
		
		
		public List<LqCoToChucEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqCoToChucEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqCoToChucEntity>();
		}
		
		
		

	}
}
