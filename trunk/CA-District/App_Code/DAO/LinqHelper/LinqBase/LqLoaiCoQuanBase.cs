




/*
'===============================================================================
'  LinqHelper.DAO.LoaiCoQuanBase
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
	public class LqLoaiCoQuanBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqLoaiCoQuanBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqLoaiCoQuanEntity obj)
		{
			provider.GetTable<LqLoaiCoQuanEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqLoaiCoQuanEntity _obj)
		{
			var q = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqLoaiCoQuanEntity tmp = q.First<LqLoaiCoQuanEntity>();
			
			tmp.TenLoaiCoQuan = _obj.TenLoaiCoQuan;
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
		
		public void Delete(LqLoaiCoQuanEntity obj)
		{
			provider.GetTable<LqLoaiCoQuanEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqLoaiCoQuanEntity ob = (LqLoaiCoQuanEntity)q.First<LqLoaiCoQuanEntity>();
            provider.GetTable<LqLoaiCoQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenLoaiCoQuan(string TenLoaiCoQuan)
		{
			var q = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                    where obj.TenLoaiCoQuan == TenLoaiCoQuan
                    select obj;
					
            LqLoaiCoQuanEntity ob = (LqLoaiCoQuanEntity)q.First<LqLoaiCoQuanEntity>();
            provider.GetTable<LqLoaiCoQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqLoaiCoQuanEntity ob = (LqLoaiCoQuanEntity)q.First<LqLoaiCoQuanEntity>();
            provider.GetTable<LqLoaiCoQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqLoaiCoQuanEntity ob = (LqLoaiCoQuanEntity)q.First<LqLoaiCoQuanEntity>();
            provider.GetTable<LqLoaiCoQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqLoaiCoQuanEntity ob = (LqLoaiCoQuanEntity)q.First<LqLoaiCoQuanEntity>();
            provider.GetTable<LqLoaiCoQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqLoaiCoQuanEntity ob = (LqLoaiCoQuanEntity)q.First<LqLoaiCoQuanEntity>();
            provider.GetTable<LqLoaiCoQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqLoaiCoQuanEntity ob = (LqLoaiCoQuanEntity)q.First<LqLoaiCoQuanEntity>();
            provider.GetTable<LqLoaiCoQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqLoaiCoQuanEntity ob = (LqLoaiCoQuanEntity)q.First<LqLoaiCoQuanEntity>();
            provider.GetTable<LqLoaiCoQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqLoaiCoQuanEntity ob = (LqLoaiCoQuanEntity)q.First<LqLoaiCoQuanEntity>();
            provider.GetTable<LqLoaiCoQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqLoaiCoQuanEntity ob = (LqLoaiCoQuanEntity)q.First<LqLoaiCoQuanEntity>();
            provider.GetTable<LqLoaiCoQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqLoaiCoQuanEntity ob = (LqLoaiCoQuanEntity)q.First<LqLoaiCoQuanEntity>();
            provider.GetTable<LqLoaiCoQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqLoaiCoQuanEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqLoaiCoQuanEntity>();
		}

		public List<LqLoaiCoQuanEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                        select obj;
            return query.ToList<LqLoaiCoQuanEntity>();
		}
		
		
		public List<LqLoaiCoQuanEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqLoaiCoQuanEntity>();
		}
		
		
		public List<LqLoaiCoQuanEntity> SelectByTenLoaiCoQuan(string TenLoaiCoQuan)
		{
			var query = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                        where obj.TenLoaiCoQuan == TenLoaiCoQuan
                        select obj;
            return query.ToList<LqLoaiCoQuanEntity>();
		}
		
		
		public List<LqLoaiCoQuanEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqLoaiCoQuanEntity>();
		}
		
		
		public List<LqLoaiCoQuanEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqLoaiCoQuanEntity>();
		}
		
		
		public List<LqLoaiCoQuanEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqLoaiCoQuanEntity>();
		}
		
		
		public List<LqLoaiCoQuanEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqLoaiCoQuanEntity>();
		}
		
		
		public List<LqLoaiCoQuanEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqLoaiCoQuanEntity>();
		}
		
		
		public List<LqLoaiCoQuanEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqLoaiCoQuanEntity>();
		}
		
		
		public List<LqLoaiCoQuanEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqLoaiCoQuanEntity>();
		}
		
		
		public List<LqLoaiCoQuanEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqLoaiCoQuanEntity>();
		}
		
		
		public List<LqLoaiCoQuanEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqLoaiCoQuanEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqLoaiCoQuanEntity>();
		}
		
		
		

	}
}
