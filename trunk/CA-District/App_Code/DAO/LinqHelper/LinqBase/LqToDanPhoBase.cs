




/*
'===============================================================================
'  LinqHelper.DAO.ToDanPhoBase
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
	public class LqToDanPhoBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqToDanPhoBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqToDanPhoEntity obj)
		{
			provider.GetTable<LqToDanPhoEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqToDanPhoEntity _obj)
		{
			var q = from obj in provider.GetTable<LqToDanPhoEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqToDanPhoEntity tmp = q.First<LqToDanPhoEntity>();
			
			tmp.TenToDanPho = _obj.TenToDanPho;
			tmp.IdOkhuVuc = _obj.IdOkhuVuc;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.GhiChu = _obj.GhiChu;
			tmp.LoaiDanhMuc = _obj.LoaiDanhMuc;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.NgayHetHan = _obj.NgayHetHan;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqToDanPhoEntity obj)
		{
			provider.GetTable<LqToDanPhoEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqToDanPhoEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqToDanPhoEntity ob = (LqToDanPhoEntity)q.First<LqToDanPhoEntity>();
            provider.GetTable<LqToDanPhoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenToDanPho(string TenToDanPho)
		{
			var q = from obj in provider.GetTable<LqToDanPhoEntity>()
                    where obj.TenToDanPho == TenToDanPho
                    select obj;
					
            LqToDanPhoEntity ob = (LqToDanPhoEntity)q.First<LqToDanPhoEntity>();
            provider.GetTable<LqToDanPhoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdOkhuVuc(Guid IdOkhuVuc)
		{
			var q = from obj in provider.GetTable<LqToDanPhoEntity>()
                    where obj.IdOkhuVuc.Value == IdOkhuVuc
                    select obj;
					
            LqToDanPhoEntity ob = (LqToDanPhoEntity)q.First<LqToDanPhoEntity>();
            provider.GetTable<LqToDanPhoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqToDanPhoEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqToDanPhoEntity ob = (LqToDanPhoEntity)q.First<LqToDanPhoEntity>();
            provider.GetTable<LqToDanPhoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqToDanPhoEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqToDanPhoEntity ob = (LqToDanPhoEntity)q.First<LqToDanPhoEntity>();
            provider.GetTable<LqToDanPhoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqToDanPhoEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqToDanPhoEntity ob = (LqToDanPhoEntity)q.First<LqToDanPhoEntity>();
            provider.GetTable<LqToDanPhoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqToDanPhoEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqToDanPhoEntity ob = (LqToDanPhoEntity)q.First<LqToDanPhoEntity>();
            provider.GetTable<LqToDanPhoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqToDanPhoEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqToDanPhoEntity ob = (LqToDanPhoEntity)q.First<LqToDanPhoEntity>();
            provider.GetTable<LqToDanPhoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqToDanPhoEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqToDanPhoEntity ob = (LqToDanPhoEntity)q.First<LqToDanPhoEntity>();
            provider.GetTable<LqToDanPhoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqToDanPhoEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqToDanPhoEntity ob = (LqToDanPhoEntity)q.First<LqToDanPhoEntity>();
            provider.GetTable<LqToDanPhoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqToDanPhoEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqToDanPhoEntity ob = (LqToDanPhoEntity)q.First<LqToDanPhoEntity>();
            provider.GetTable<LqToDanPhoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqToDanPhoEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqToDanPhoEntity ob = (LqToDanPhoEntity)q.First<LqToDanPhoEntity>();
            provider.GetTable<LqToDanPhoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqToDanPhoEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqToDanPhoEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqToDanPhoEntity>();
		}

		public List<LqToDanPhoEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqToDanPhoEntity>()
                        select obj;
            return query.ToList<LqToDanPhoEntity>();
		}
		
		
		public List<LqToDanPhoEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqToDanPhoEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqToDanPhoEntity>();
		}
		
		
		public List<LqToDanPhoEntity> SelectByTenToDanPho(string TenToDanPho)
		{
			var query = from obj in provider.GetTable<LqToDanPhoEntity>()
                        where obj.TenToDanPho == TenToDanPho
                        select obj;
            return query.ToList<LqToDanPhoEntity>();
		}
		
		
		public List<LqToDanPhoEntity> SelectByIdOkhuVuc(Guid IdOkhuVuc)
		{
			var query = from obj in provider.GetTable<LqToDanPhoEntity>()
                        where obj.IdOkhuVuc.Value == IdOkhuVuc
                        select obj;
            return query.ToList<LqToDanPhoEntity>();
		}
		
		
		public List<LqToDanPhoEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqToDanPhoEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqToDanPhoEntity>();
		}
		
		
		public List<LqToDanPhoEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqToDanPhoEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqToDanPhoEntity>();
		}
		
		
		public List<LqToDanPhoEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqToDanPhoEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqToDanPhoEntity>();
		}
		
		
		public List<LqToDanPhoEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqToDanPhoEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqToDanPhoEntity>();
		}
		
		
		public List<LqToDanPhoEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqToDanPhoEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqToDanPhoEntity>();
		}
		
		
		public List<LqToDanPhoEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqToDanPhoEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqToDanPhoEntity>();
		}
		
		
		public List<LqToDanPhoEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqToDanPhoEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqToDanPhoEntity>();
		}
		
		
		public List<LqToDanPhoEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqToDanPhoEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqToDanPhoEntity>();
		}
		
		
		public List<LqToDanPhoEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqToDanPhoEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqToDanPhoEntity>();
		}
		
		
		

	}
}
