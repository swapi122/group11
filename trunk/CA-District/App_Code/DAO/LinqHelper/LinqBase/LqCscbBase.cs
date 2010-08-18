




/*
'===============================================================================
'  LinqHelper.DAO.CscbBase
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
	public class LqCscbBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqCscbBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqCscbEntity obj)
		{
			provider.GetTable<LqCscbEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqCscbEntity _obj)
		{
			var q = from obj in provider.GetTable<LqCscbEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqCscbEntity tmp = q.First<LqCscbEntity>();
			
			tmp.TenCscb = _obj.TenCscb;
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
		
		public void Delete(LqCscbEntity obj)
		{
			provider.GetTable<LqCscbEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqCscbEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqCscbEntity ob = (LqCscbEntity)q.First<LqCscbEntity>();
            provider.GetTable<LqCscbEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenCscb(string TenCscb)
		{
			var q = from obj in provider.GetTable<LqCscbEntity>()
                    where obj.TenCscb == TenCscb
                    select obj;
					
            LqCscbEntity ob = (LqCscbEntity)q.First<LqCscbEntity>();
            provider.GetTable<LqCscbEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqCscbEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqCscbEntity ob = (LqCscbEntity)q.First<LqCscbEntity>();
            provider.GetTable<LqCscbEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqCscbEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqCscbEntity ob = (LqCscbEntity)q.First<LqCscbEntity>();
            provider.GetTable<LqCscbEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqCscbEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqCscbEntity ob = (LqCscbEntity)q.First<LqCscbEntity>();
            provider.GetTable<LqCscbEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqCscbEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqCscbEntity ob = (LqCscbEntity)q.First<LqCscbEntity>();
            provider.GetTable<LqCscbEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqCscbEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqCscbEntity ob = (LqCscbEntity)q.First<LqCscbEntity>();
            provider.GetTable<LqCscbEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqCscbEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqCscbEntity ob = (LqCscbEntity)q.First<LqCscbEntity>();
            provider.GetTable<LqCscbEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqCscbEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqCscbEntity ob = (LqCscbEntity)q.First<LqCscbEntity>();
            provider.GetTable<LqCscbEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqCscbEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqCscbEntity ob = (LqCscbEntity)q.First<LqCscbEntity>();
            provider.GetTable<LqCscbEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqCscbEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqCscbEntity ob = (LqCscbEntity)q.First<LqCscbEntity>();
            provider.GetTable<LqCscbEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqCscbEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqCscbEntity ob = (LqCscbEntity)q.First<LqCscbEntity>();
            provider.GetTable<LqCscbEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqCscbEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqCscbEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqCscbEntity>();
		}

		public List<LqCscbEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqCscbEntity>()
                        select obj;
            return query.ToList<LqCscbEntity>();
		}
		
		
		public List<LqCscbEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqCscbEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqCscbEntity>();
		}
		
		
		public List<LqCscbEntity> SelectByTenCscb(string TenCscb)
		{
			var query = from obj in provider.GetTable<LqCscbEntity>()
                        where obj.TenCscb == TenCscb
                        select obj;
            return query.ToList<LqCscbEntity>();
		}
		
		
		public List<LqCscbEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqCscbEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqCscbEntity>();
		}
		
		
		public List<LqCscbEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqCscbEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqCscbEntity>();
		}
		
		
		public List<LqCscbEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqCscbEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqCscbEntity>();
		}
		
		
		public List<LqCscbEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqCscbEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqCscbEntity>();
		}
		
		
		public List<LqCscbEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqCscbEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqCscbEntity>();
		}
		
		
		public List<LqCscbEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqCscbEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqCscbEntity>();
		}
		
		
		public List<LqCscbEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqCscbEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqCscbEntity>();
		}
		
		
		public List<LqCscbEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqCscbEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqCscbEntity>();
		}
		
		
		public List<LqCscbEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqCscbEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqCscbEntity>();
		}
		
		
		public List<LqCscbEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqCscbEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqCscbEntity>();
		}
		
		
		

	}
}
