




/*
'===============================================================================
'  LinqHelper.DAO.NgheNghiepBase
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
	public class LqNgheNghiepBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNgheNghiepBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqNgheNghiepEntity obj)
		{
			provider.GetTable<LqNgheNghiepEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqNgheNghiepEntity _obj)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqNgheNghiepEntity tmp = q.First<LqNgheNghiepEntity>();
			
			tmp.TenNgheNghiep = _obj.TenNgheNghiep;
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
		
		public void Delete(LqNgheNghiepEntity obj)
		{
			provider.GetTable<LqNgheNghiepEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqNgheNghiepEntity ob = (LqNgheNghiepEntity)q.First<LqNgheNghiepEntity>();
            provider.GetTable<LqNgheNghiepEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenNgheNghiep(string TenNgheNghiep)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepEntity>()
                    where obj.TenNgheNghiep == TenNgheNghiep
                    select obj;
					
            LqNgheNghiepEntity ob = (LqNgheNghiepEntity)q.First<LqNgheNghiepEntity>();
            provider.GetTable<LqNgheNghiepEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqNgheNghiepEntity ob = (LqNgheNghiepEntity)q.First<LqNgheNghiepEntity>();
            provider.GetTable<LqNgheNghiepEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqNgheNghiepEntity ob = (LqNgheNghiepEntity)q.First<LqNgheNghiepEntity>();
            provider.GetTable<LqNgheNghiepEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqNgheNghiepEntity ob = (LqNgheNghiepEntity)q.First<LqNgheNghiepEntity>();
            provider.GetTable<LqNgheNghiepEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqNgheNghiepEntity ob = (LqNgheNghiepEntity)q.First<LqNgheNghiepEntity>();
            provider.GetTable<LqNgheNghiepEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqNgheNghiepEntity ob = (LqNgheNghiepEntity)q.First<LqNgheNghiepEntity>();
            provider.GetTable<LqNgheNghiepEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqNgheNghiepEntity ob = (LqNgheNghiepEntity)q.First<LqNgheNghiepEntity>();
            provider.GetTable<LqNgheNghiepEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqNgheNghiepEntity ob = (LqNgheNghiepEntity)q.First<LqNgheNghiepEntity>();
            provider.GetTable<LqNgheNghiepEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqNgheNghiepEntity ob = (LqNgheNghiepEntity)q.First<LqNgheNghiepEntity>();
            provider.GetTable<LqNgheNghiepEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqNgheNghiepEntity ob = (LqNgheNghiepEntity)q.First<LqNgheNghiepEntity>();
            provider.GetTable<LqNgheNghiepEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqNgheNghiepEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqNgheNghiepEntity ob = (LqNgheNghiepEntity)q.First<LqNgheNghiepEntity>();
            provider.GetTable<LqNgheNghiepEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqNgheNghiepEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqNgheNghiepEntity>();
		}

		public List<LqNgheNghiepEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqNgheNghiepEntity>()
                        select obj;
            return query.ToList<LqNgheNghiepEntity>();
		}
		
		
		public List<LqNgheNghiepEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqNgheNghiepEntity>();
		}
		
		
		public List<LqNgheNghiepEntity> SelectByTenNgheNghiep(string TenNgheNghiep)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepEntity>()
                        where obj.TenNgheNghiep == TenNgheNghiep
                        select obj;
            return query.ToList<LqNgheNghiepEntity>();
		}
		
		
		public List<LqNgheNghiepEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqNgheNghiepEntity>();
		}
		
		
		public List<LqNgheNghiepEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqNgheNghiepEntity>();
		}
		
		
		public List<LqNgheNghiepEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqNgheNghiepEntity>();
		}
		
		
		public List<LqNgheNghiepEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqNgheNghiepEntity>();
		}
		
		
		public List<LqNgheNghiepEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqNgheNghiepEntity>();
		}
		
		
		public List<LqNgheNghiepEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqNgheNghiepEntity>();
		}
		
		
		public List<LqNgheNghiepEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqNgheNghiepEntity>();
		}
		
		
		public List<LqNgheNghiepEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqNgheNghiepEntity>();
		}
		
		
		public List<LqNgheNghiepEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqNgheNghiepEntity>();
		}
		
		
		public List<LqNgheNghiepEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqNgheNghiepEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqNgheNghiepEntity>();
		}
		
		
		

	}
}
