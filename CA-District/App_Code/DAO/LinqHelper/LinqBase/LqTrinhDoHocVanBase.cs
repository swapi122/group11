




/*
'===============================================================================
'  LinqHelper.DAO.TrinhDoHocVanBase
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
	public class LqTrinhDoHocVanBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTrinhDoHocVanBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqTrinhDoHocVanEntity obj)
		{
			provider.GetTable<LqTrinhDoHocVanEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqTrinhDoHocVanEntity _obj)
		{
			var q = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqTrinhDoHocVanEntity tmp = q.First<LqTrinhDoHocVanEntity>();
			
			tmp.TenTrinhDoHocVan = _obj.TenTrinhDoHocVan;
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
		
		public void Delete(LqTrinhDoHocVanEntity obj)
		{
			provider.GetTable<LqTrinhDoHocVanEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqTrinhDoHocVanEntity ob = (LqTrinhDoHocVanEntity)q.First<LqTrinhDoHocVanEntity>();
            provider.GetTable<LqTrinhDoHocVanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenTrinhDoHocVan(string TenTrinhDoHocVan)
		{
			var q = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                    where obj.TenTrinhDoHocVan == TenTrinhDoHocVan
                    select obj;
					
            LqTrinhDoHocVanEntity ob = (LqTrinhDoHocVanEntity)q.First<LqTrinhDoHocVanEntity>();
            provider.GetTable<LqTrinhDoHocVanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqTrinhDoHocVanEntity ob = (LqTrinhDoHocVanEntity)q.First<LqTrinhDoHocVanEntity>();
            provider.GetTable<LqTrinhDoHocVanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqTrinhDoHocVanEntity ob = (LqTrinhDoHocVanEntity)q.First<LqTrinhDoHocVanEntity>();
            provider.GetTable<LqTrinhDoHocVanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqTrinhDoHocVanEntity ob = (LqTrinhDoHocVanEntity)q.First<LqTrinhDoHocVanEntity>();
            provider.GetTable<LqTrinhDoHocVanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqTrinhDoHocVanEntity ob = (LqTrinhDoHocVanEntity)q.First<LqTrinhDoHocVanEntity>();
            provider.GetTable<LqTrinhDoHocVanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqTrinhDoHocVanEntity ob = (LqTrinhDoHocVanEntity)q.First<LqTrinhDoHocVanEntity>();
            provider.GetTable<LqTrinhDoHocVanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqTrinhDoHocVanEntity ob = (LqTrinhDoHocVanEntity)q.First<LqTrinhDoHocVanEntity>();
            provider.GetTable<LqTrinhDoHocVanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqTrinhDoHocVanEntity ob = (LqTrinhDoHocVanEntity)q.First<LqTrinhDoHocVanEntity>();
            provider.GetTable<LqTrinhDoHocVanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqTrinhDoHocVanEntity ob = (LqTrinhDoHocVanEntity)q.First<LqTrinhDoHocVanEntity>();
            provider.GetTable<LqTrinhDoHocVanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqTrinhDoHocVanEntity ob = (LqTrinhDoHocVanEntity)q.First<LqTrinhDoHocVanEntity>();
            provider.GetTable<LqTrinhDoHocVanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqTrinhDoHocVanEntity ob = (LqTrinhDoHocVanEntity)q.First<LqTrinhDoHocVanEntity>();
            provider.GetTable<LqTrinhDoHocVanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqTrinhDoHocVanEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqTrinhDoHocVanEntity>();
		}

		public List<LqTrinhDoHocVanEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                        select obj;
            return query.ToList<LqTrinhDoHocVanEntity>();
		}
		
		
		public List<LqTrinhDoHocVanEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqTrinhDoHocVanEntity>();
		}
		
		
		public List<LqTrinhDoHocVanEntity> SelectByTenTrinhDoHocVan(string TenTrinhDoHocVan)
		{
			var query = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                        where obj.TenTrinhDoHocVan == TenTrinhDoHocVan
                        select obj;
            return query.ToList<LqTrinhDoHocVanEntity>();
		}
		
		
		public List<LqTrinhDoHocVanEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqTrinhDoHocVanEntity>();
		}
		
		
		public List<LqTrinhDoHocVanEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqTrinhDoHocVanEntity>();
		}
		
		
		public List<LqTrinhDoHocVanEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqTrinhDoHocVanEntity>();
		}
		
		
		public List<LqTrinhDoHocVanEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqTrinhDoHocVanEntity>();
		}
		
		
		public List<LqTrinhDoHocVanEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqTrinhDoHocVanEntity>();
		}
		
		
		public List<LqTrinhDoHocVanEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqTrinhDoHocVanEntity>();
		}
		
		
		public List<LqTrinhDoHocVanEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqTrinhDoHocVanEntity>();
		}
		
		
		public List<LqTrinhDoHocVanEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqTrinhDoHocVanEntity>();
		}
		
		
		public List<LqTrinhDoHocVanEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqTrinhDoHocVanEntity>();
		}
		
		
		public List<LqTrinhDoHocVanEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqTrinhDoHocVanEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqTrinhDoHocVanEntity>();
		}
		
		
		

	}
}
