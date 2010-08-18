




/*
'===============================================================================
'  LinqHelper.DAO.NguyenNhanXayRaBase
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
	public class LqNguyenNhanXayRaBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNguyenNhanXayRaBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqNguyenNhanXayRaEntity obj)
		{
			provider.GetTable<LqNguyenNhanXayRaEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqNguyenNhanXayRaEntity _obj)
		{
			var q = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqNguyenNhanXayRaEntity tmp = q.First<LqNguyenNhanXayRaEntity>();
			
			tmp.TenNguyenNhanXayRa = _obj.TenNguyenNhanXayRa;
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
		
		public void Delete(LqNguyenNhanXayRaEntity obj)
		{
			provider.GetTable<LqNguyenNhanXayRaEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqNguyenNhanXayRaEntity ob = (LqNguyenNhanXayRaEntity)q.First<LqNguyenNhanXayRaEntity>();
            provider.GetTable<LqNguyenNhanXayRaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenNguyenNhanXayRa(string TenNguyenNhanXayRa)
		{
			var q = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                    where obj.TenNguyenNhanXayRa == TenNguyenNhanXayRa
                    select obj;
					
            LqNguyenNhanXayRaEntity ob = (LqNguyenNhanXayRaEntity)q.First<LqNguyenNhanXayRaEntity>();
            provider.GetTable<LqNguyenNhanXayRaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqNguyenNhanXayRaEntity ob = (LqNguyenNhanXayRaEntity)q.First<LqNguyenNhanXayRaEntity>();
            provider.GetTable<LqNguyenNhanXayRaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqNguyenNhanXayRaEntity ob = (LqNguyenNhanXayRaEntity)q.First<LqNguyenNhanXayRaEntity>();
            provider.GetTable<LqNguyenNhanXayRaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqNguyenNhanXayRaEntity ob = (LqNguyenNhanXayRaEntity)q.First<LqNguyenNhanXayRaEntity>();
            provider.GetTable<LqNguyenNhanXayRaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqNguyenNhanXayRaEntity ob = (LqNguyenNhanXayRaEntity)q.First<LqNguyenNhanXayRaEntity>();
            provider.GetTable<LqNguyenNhanXayRaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqNguyenNhanXayRaEntity ob = (LqNguyenNhanXayRaEntity)q.First<LqNguyenNhanXayRaEntity>();
            provider.GetTable<LqNguyenNhanXayRaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqNguyenNhanXayRaEntity ob = (LqNguyenNhanXayRaEntity)q.First<LqNguyenNhanXayRaEntity>();
            provider.GetTable<LqNguyenNhanXayRaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqNguyenNhanXayRaEntity ob = (LqNguyenNhanXayRaEntity)q.First<LqNguyenNhanXayRaEntity>();
            provider.GetTable<LqNguyenNhanXayRaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqNguyenNhanXayRaEntity ob = (LqNguyenNhanXayRaEntity)q.First<LqNguyenNhanXayRaEntity>();
            provider.GetTable<LqNguyenNhanXayRaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqNguyenNhanXayRaEntity ob = (LqNguyenNhanXayRaEntity)q.First<LqNguyenNhanXayRaEntity>();
            provider.GetTable<LqNguyenNhanXayRaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqNguyenNhanXayRaEntity ob = (LqNguyenNhanXayRaEntity)q.First<LqNguyenNhanXayRaEntity>();
            provider.GetTable<LqNguyenNhanXayRaEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqNguyenNhanXayRaEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqNguyenNhanXayRaEntity>();
		}

		public List<LqNguyenNhanXayRaEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                        select obj;
            return query.ToList<LqNguyenNhanXayRaEntity>();
		}
		
		
		public List<LqNguyenNhanXayRaEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqNguyenNhanXayRaEntity>();
		}
		
		
		public List<LqNguyenNhanXayRaEntity> SelectByTenNguyenNhanXayRa(string TenNguyenNhanXayRa)
		{
			var query = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                        where obj.TenNguyenNhanXayRa == TenNguyenNhanXayRa
                        select obj;
            return query.ToList<LqNguyenNhanXayRaEntity>();
		}
		
		
		public List<LqNguyenNhanXayRaEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqNguyenNhanXayRaEntity>();
		}
		
		
		public List<LqNguyenNhanXayRaEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqNguyenNhanXayRaEntity>();
		}
		
		
		public List<LqNguyenNhanXayRaEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqNguyenNhanXayRaEntity>();
		}
		
		
		public List<LqNguyenNhanXayRaEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqNguyenNhanXayRaEntity>();
		}
		
		
		public List<LqNguyenNhanXayRaEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqNguyenNhanXayRaEntity>();
		}
		
		
		public List<LqNguyenNhanXayRaEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqNguyenNhanXayRaEntity>();
		}
		
		
		public List<LqNguyenNhanXayRaEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqNguyenNhanXayRaEntity>();
		}
		
		
		public List<LqNguyenNhanXayRaEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqNguyenNhanXayRaEntity>();
		}
		
		
		public List<LqNguyenNhanXayRaEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqNguyenNhanXayRaEntity>();
		}
		
		
		public List<LqNguyenNhanXayRaEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqNguyenNhanXayRaEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqNguyenNhanXayRaEntity>();
		}
		
		
		

	}
}
