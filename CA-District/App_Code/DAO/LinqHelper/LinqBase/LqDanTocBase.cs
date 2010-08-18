




/*
'===============================================================================
'  LinqHelper.DAO.DanTocBase
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
	public class LqDanTocBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDanTocBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqDanTocEntity obj)
		{
			provider.GetTable<LqDanTocEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqDanTocEntity _obj)
		{
			var q = from obj in provider.GetTable<LqDanTocEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqDanTocEntity tmp = q.First<LqDanTocEntity>();
			
			tmp.TenDanToc = _obj.TenDanToc;
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
		
		public void Delete(LqDanTocEntity obj)
		{
			provider.GetTable<LqDanTocEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqDanTocEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqDanTocEntity ob = (LqDanTocEntity)q.First<LqDanTocEntity>();
            provider.GetTable<LqDanTocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenDanToc(string TenDanToc)
		{
			var q = from obj in provider.GetTable<LqDanTocEntity>()
                    where obj.TenDanToc == TenDanToc
                    select obj;
					
            LqDanTocEntity ob = (LqDanTocEntity)q.First<LqDanTocEntity>();
            provider.GetTable<LqDanTocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqDanTocEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqDanTocEntity ob = (LqDanTocEntity)q.First<LqDanTocEntity>();
            provider.GetTable<LqDanTocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqDanTocEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqDanTocEntity ob = (LqDanTocEntity)q.First<LqDanTocEntity>();
            provider.GetTable<LqDanTocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqDanTocEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqDanTocEntity ob = (LqDanTocEntity)q.First<LqDanTocEntity>();
            provider.GetTable<LqDanTocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqDanTocEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqDanTocEntity ob = (LqDanTocEntity)q.First<LqDanTocEntity>();
            provider.GetTable<LqDanTocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqDanTocEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqDanTocEntity ob = (LqDanTocEntity)q.First<LqDanTocEntity>();
            provider.GetTable<LqDanTocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqDanTocEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqDanTocEntity ob = (LqDanTocEntity)q.First<LqDanTocEntity>();
            provider.GetTable<LqDanTocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqDanTocEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqDanTocEntity ob = (LqDanTocEntity)q.First<LqDanTocEntity>();
            provider.GetTable<LqDanTocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqDanTocEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqDanTocEntity ob = (LqDanTocEntity)q.First<LqDanTocEntity>();
            provider.GetTable<LqDanTocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqDanTocEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqDanTocEntity ob = (LqDanTocEntity)q.First<LqDanTocEntity>();
            provider.GetTable<LqDanTocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqDanTocEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqDanTocEntity ob = (LqDanTocEntity)q.First<LqDanTocEntity>();
            provider.GetTable<LqDanTocEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqDanTocEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqDanTocEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqDanTocEntity>();
		}

		public List<LqDanTocEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqDanTocEntity>()
                        select obj;
            return query.ToList<LqDanTocEntity>();
		}
		
		
		public List<LqDanTocEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqDanTocEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqDanTocEntity>();
		}
		
		
		public List<LqDanTocEntity> SelectByTenDanToc(string TenDanToc)
		{
			var query = from obj in provider.GetTable<LqDanTocEntity>()
                        where obj.TenDanToc == TenDanToc
                        select obj;
            return query.ToList<LqDanTocEntity>();
		}
		
		
		public List<LqDanTocEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqDanTocEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqDanTocEntity>();
		}
		
		
		public List<LqDanTocEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqDanTocEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqDanTocEntity>();
		}
		
		
		public List<LqDanTocEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqDanTocEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqDanTocEntity>();
		}
		
		
		public List<LqDanTocEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqDanTocEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqDanTocEntity>();
		}
		
		
		public List<LqDanTocEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqDanTocEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqDanTocEntity>();
		}
		
		
		public List<LqDanTocEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqDanTocEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqDanTocEntity>();
		}
		
		
		public List<LqDanTocEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqDanTocEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqDanTocEntity>();
		}
		
		
		public List<LqDanTocEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqDanTocEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqDanTocEntity>();
		}
		
		
		public List<LqDanTocEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqDanTocEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqDanTocEntity>();
		}
		
		
		public List<LqDanTocEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqDanTocEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqDanTocEntity>();
		}
		
		
		

	}
}
