




/*
'===============================================================================
'  LinqHelper.DAO.VanDeKhacBase
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
	public class LqVanDeKhacBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVanDeKhacBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqVanDeKhacEntity obj)
		{
			provider.GetTable<LqVanDeKhacEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqVanDeKhacEntity _obj)
		{
			var q = from obj in provider.GetTable<LqVanDeKhacEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqVanDeKhacEntity tmp = q.First<LqVanDeKhacEntity>();
			
			tmp.TenVanDeKhac = _obj.TenVanDeKhac;
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
		
		public void Delete(LqVanDeKhacEntity obj)
		{
			provider.GetTable<LqVanDeKhacEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqVanDeKhacEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqVanDeKhacEntity ob = (LqVanDeKhacEntity)q.First<LqVanDeKhacEntity>();
            provider.GetTable<LqVanDeKhacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenVanDeKhac(string TenVanDeKhac)
		{
			var q = from obj in provider.GetTable<LqVanDeKhacEntity>()
                    where obj.TenVanDeKhac == TenVanDeKhac
                    select obj;
					
            LqVanDeKhacEntity ob = (LqVanDeKhacEntity)q.First<LqVanDeKhacEntity>();
            provider.GetTable<LqVanDeKhacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqVanDeKhacEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqVanDeKhacEntity ob = (LqVanDeKhacEntity)q.First<LqVanDeKhacEntity>();
            provider.GetTable<LqVanDeKhacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqVanDeKhacEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqVanDeKhacEntity ob = (LqVanDeKhacEntity)q.First<LqVanDeKhacEntity>();
            provider.GetTable<LqVanDeKhacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqVanDeKhacEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqVanDeKhacEntity ob = (LqVanDeKhacEntity)q.First<LqVanDeKhacEntity>();
            provider.GetTable<LqVanDeKhacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqVanDeKhacEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqVanDeKhacEntity ob = (LqVanDeKhacEntity)q.First<LqVanDeKhacEntity>();
            provider.GetTable<LqVanDeKhacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqVanDeKhacEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqVanDeKhacEntity ob = (LqVanDeKhacEntity)q.First<LqVanDeKhacEntity>();
            provider.GetTable<LqVanDeKhacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqVanDeKhacEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqVanDeKhacEntity ob = (LqVanDeKhacEntity)q.First<LqVanDeKhacEntity>();
            provider.GetTable<LqVanDeKhacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqVanDeKhacEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqVanDeKhacEntity ob = (LqVanDeKhacEntity)q.First<LqVanDeKhacEntity>();
            provider.GetTable<LqVanDeKhacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqVanDeKhacEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqVanDeKhacEntity ob = (LqVanDeKhacEntity)q.First<LqVanDeKhacEntity>();
            provider.GetTable<LqVanDeKhacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqVanDeKhacEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqVanDeKhacEntity ob = (LqVanDeKhacEntity)q.First<LqVanDeKhacEntity>();
            provider.GetTable<LqVanDeKhacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqVanDeKhacEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqVanDeKhacEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqVanDeKhacEntity>();
		}

		public List<LqVanDeKhacEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqVanDeKhacEntity>()
                        select obj;
            return query.ToList<LqVanDeKhacEntity>();
		}
		
		
		public List<LqVanDeKhacEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqVanDeKhacEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqVanDeKhacEntity>();
		}
		
		
		public List<LqVanDeKhacEntity> SelectByTenVanDeKhac(string TenVanDeKhac)
		{
			var query = from obj in provider.GetTable<LqVanDeKhacEntity>()
                        where obj.TenVanDeKhac == TenVanDeKhac
                        select obj;
            return query.ToList<LqVanDeKhacEntity>();
		}
		
		
		public List<LqVanDeKhacEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqVanDeKhacEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqVanDeKhacEntity>();
		}
		
		
		public List<LqVanDeKhacEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqVanDeKhacEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqVanDeKhacEntity>();
		}
		
		
		public List<LqVanDeKhacEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqVanDeKhacEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqVanDeKhacEntity>();
		}
		
		
		public List<LqVanDeKhacEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqVanDeKhacEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqVanDeKhacEntity>();
		}
		
		
		public List<LqVanDeKhacEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqVanDeKhacEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqVanDeKhacEntity>();
		}
		
		
		public List<LqVanDeKhacEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqVanDeKhacEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqVanDeKhacEntity>();
		}
		
		
		public List<LqVanDeKhacEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqVanDeKhacEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqVanDeKhacEntity>();
		}
		
		
		public List<LqVanDeKhacEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqVanDeKhacEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqVanDeKhacEntity>();
		}
		
		
		public List<LqVanDeKhacEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqVanDeKhacEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqVanDeKhacEntity>();
		}
		
		
		

	}
}
