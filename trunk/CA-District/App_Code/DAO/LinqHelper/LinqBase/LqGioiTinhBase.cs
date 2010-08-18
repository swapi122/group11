




/*
'===============================================================================
'  LinqHelper.DAO.GioiTinhBase
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
	public class LqGioiTinhBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqGioiTinhBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqGioiTinhEntity obj)
		{
			provider.GetTable<LqGioiTinhEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqGioiTinhEntity _obj)
		{
			var q = from obj in provider.GetTable<LqGioiTinhEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqGioiTinhEntity tmp = q.First<LqGioiTinhEntity>();
			
			tmp.TenGioiTinh = _obj.TenGioiTinh;
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
		
		public void Delete(LqGioiTinhEntity obj)
		{
			provider.GetTable<LqGioiTinhEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqGioiTinhEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqGioiTinhEntity ob = (LqGioiTinhEntity)q.First<LqGioiTinhEntity>();
            provider.GetTable<LqGioiTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenGioiTinh(string TenGioiTinh)
		{
			var q = from obj in provider.GetTable<LqGioiTinhEntity>()
                    where obj.TenGioiTinh == TenGioiTinh
                    select obj;
					
            LqGioiTinhEntity ob = (LqGioiTinhEntity)q.First<LqGioiTinhEntity>();
            provider.GetTable<LqGioiTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqGioiTinhEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqGioiTinhEntity ob = (LqGioiTinhEntity)q.First<LqGioiTinhEntity>();
            provider.GetTable<LqGioiTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqGioiTinhEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqGioiTinhEntity ob = (LqGioiTinhEntity)q.First<LqGioiTinhEntity>();
            provider.GetTable<LqGioiTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqGioiTinhEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqGioiTinhEntity ob = (LqGioiTinhEntity)q.First<LqGioiTinhEntity>();
            provider.GetTable<LqGioiTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqGioiTinhEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqGioiTinhEntity ob = (LqGioiTinhEntity)q.First<LqGioiTinhEntity>();
            provider.GetTable<LqGioiTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqGioiTinhEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqGioiTinhEntity ob = (LqGioiTinhEntity)q.First<LqGioiTinhEntity>();
            provider.GetTable<LqGioiTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqGioiTinhEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqGioiTinhEntity ob = (LqGioiTinhEntity)q.First<LqGioiTinhEntity>();
            provider.GetTable<LqGioiTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqGioiTinhEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqGioiTinhEntity ob = (LqGioiTinhEntity)q.First<LqGioiTinhEntity>();
            provider.GetTable<LqGioiTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqGioiTinhEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqGioiTinhEntity ob = (LqGioiTinhEntity)q.First<LqGioiTinhEntity>();
            provider.GetTable<LqGioiTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqGioiTinhEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqGioiTinhEntity ob = (LqGioiTinhEntity)q.First<LqGioiTinhEntity>();
            provider.GetTable<LqGioiTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqGioiTinhEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqGioiTinhEntity ob = (LqGioiTinhEntity)q.First<LqGioiTinhEntity>();
            provider.GetTable<LqGioiTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqGioiTinhEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqGioiTinhEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqGioiTinhEntity>();
		}

		public List<LqGioiTinhEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqGioiTinhEntity>()
                        select obj;
            return query.ToList<LqGioiTinhEntity>();
		}
		
		
		public List<LqGioiTinhEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqGioiTinhEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqGioiTinhEntity>();
		}
		
		
		public List<LqGioiTinhEntity> SelectByTenGioiTinh(string TenGioiTinh)
		{
			var query = from obj in provider.GetTable<LqGioiTinhEntity>()
                        where obj.TenGioiTinh == TenGioiTinh
                        select obj;
            return query.ToList<LqGioiTinhEntity>();
		}
		
		
		public List<LqGioiTinhEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqGioiTinhEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqGioiTinhEntity>();
		}
		
		
		public List<LqGioiTinhEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqGioiTinhEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqGioiTinhEntity>();
		}
		
		
		public List<LqGioiTinhEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqGioiTinhEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqGioiTinhEntity>();
		}
		
		
		public List<LqGioiTinhEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqGioiTinhEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqGioiTinhEntity>();
		}
		
		
		public List<LqGioiTinhEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqGioiTinhEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqGioiTinhEntity>();
		}
		
		
		public List<LqGioiTinhEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqGioiTinhEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqGioiTinhEntity>();
		}
		
		
		public List<LqGioiTinhEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqGioiTinhEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqGioiTinhEntity>();
		}
		
		
		public List<LqGioiTinhEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqGioiTinhEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqGioiTinhEntity>();
		}
		
		
		public List<LqGioiTinhEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqGioiTinhEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqGioiTinhEntity>();
		}
		
		
		public List<LqGioiTinhEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqGioiTinhEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqGioiTinhEntity>();
		}
		
		
		

	}
}
