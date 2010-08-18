




/*
'===============================================================================
'  LinqHelper.DAO.TinhTrangTheTrangBase
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
	public class LqTinhTrangTheTrangBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTinhTrangTheTrangBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqTinhTrangTheTrangEntity obj)
		{
			provider.GetTable<LqTinhTrangTheTrangEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqTinhTrangTheTrangEntity _obj)
		{
			var q = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqTinhTrangTheTrangEntity tmp = q.First<LqTinhTrangTheTrangEntity>();
			
			tmp.TenTinhTrangTheTrang = _obj.TenTinhTrangTheTrang;
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
		
		public void Delete(LqTinhTrangTheTrangEntity obj)
		{
			provider.GetTable<LqTinhTrangTheTrangEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqTinhTrangTheTrangEntity ob = (LqTinhTrangTheTrangEntity)q.First<LqTinhTrangTheTrangEntity>();
            provider.GetTable<LqTinhTrangTheTrangEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenTinhTrangTheTrang(string TenTinhTrangTheTrang)
		{
			var q = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                    where obj.TenTinhTrangTheTrang == TenTinhTrangTheTrang
                    select obj;
					
            LqTinhTrangTheTrangEntity ob = (LqTinhTrangTheTrangEntity)q.First<LqTinhTrangTheTrangEntity>();
            provider.GetTable<LqTinhTrangTheTrangEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqTinhTrangTheTrangEntity ob = (LqTinhTrangTheTrangEntity)q.First<LqTinhTrangTheTrangEntity>();
            provider.GetTable<LqTinhTrangTheTrangEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqTinhTrangTheTrangEntity ob = (LqTinhTrangTheTrangEntity)q.First<LqTinhTrangTheTrangEntity>();
            provider.GetTable<LqTinhTrangTheTrangEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqTinhTrangTheTrangEntity ob = (LqTinhTrangTheTrangEntity)q.First<LqTinhTrangTheTrangEntity>();
            provider.GetTable<LqTinhTrangTheTrangEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqTinhTrangTheTrangEntity ob = (LqTinhTrangTheTrangEntity)q.First<LqTinhTrangTheTrangEntity>();
            provider.GetTable<LqTinhTrangTheTrangEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqTinhTrangTheTrangEntity ob = (LqTinhTrangTheTrangEntity)q.First<LqTinhTrangTheTrangEntity>();
            provider.GetTable<LqTinhTrangTheTrangEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqTinhTrangTheTrangEntity ob = (LqTinhTrangTheTrangEntity)q.First<LqTinhTrangTheTrangEntity>();
            provider.GetTable<LqTinhTrangTheTrangEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqTinhTrangTheTrangEntity ob = (LqTinhTrangTheTrangEntity)q.First<LqTinhTrangTheTrangEntity>();
            provider.GetTable<LqTinhTrangTheTrangEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqTinhTrangTheTrangEntity ob = (LqTinhTrangTheTrangEntity)q.First<LqTinhTrangTheTrangEntity>();
            provider.GetTable<LqTinhTrangTheTrangEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqTinhTrangTheTrangEntity ob = (LqTinhTrangTheTrangEntity)q.First<LqTinhTrangTheTrangEntity>();
            provider.GetTable<LqTinhTrangTheTrangEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqTinhTrangTheTrangEntity ob = (LqTinhTrangTheTrangEntity)q.First<LqTinhTrangTheTrangEntity>();
            provider.GetTable<LqTinhTrangTheTrangEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqTinhTrangTheTrangEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqTinhTrangTheTrangEntity>();
		}

		public List<LqTinhTrangTheTrangEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                        select obj;
            return query.ToList<LqTinhTrangTheTrangEntity>();
		}
		
		
		public List<LqTinhTrangTheTrangEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqTinhTrangTheTrangEntity>();
		}
		
		
		public List<LqTinhTrangTheTrangEntity> SelectByTenTinhTrangTheTrang(string TenTinhTrangTheTrang)
		{
			var query = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                        where obj.TenTinhTrangTheTrang == TenTinhTrangTheTrang
                        select obj;
            return query.ToList<LqTinhTrangTheTrangEntity>();
		}
		
		
		public List<LqTinhTrangTheTrangEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqTinhTrangTheTrangEntity>();
		}
		
		
		public List<LqTinhTrangTheTrangEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqTinhTrangTheTrangEntity>();
		}
		
		
		public List<LqTinhTrangTheTrangEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqTinhTrangTheTrangEntity>();
		}
		
		
		public List<LqTinhTrangTheTrangEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqTinhTrangTheTrangEntity>();
		}
		
		
		public List<LqTinhTrangTheTrangEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqTinhTrangTheTrangEntity>();
		}
		
		
		public List<LqTinhTrangTheTrangEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqTinhTrangTheTrangEntity>();
		}
		
		
		public List<LqTinhTrangTheTrangEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqTinhTrangTheTrangEntity>();
		}
		
		
		public List<LqTinhTrangTheTrangEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqTinhTrangTheTrangEntity>();
		}
		
		
		public List<LqTinhTrangTheTrangEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqTinhTrangTheTrangEntity>();
		}
		
		
		public List<LqTinhTrangTheTrangEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqTinhTrangTheTrangEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqTinhTrangTheTrangEntity>();
		}
		
		
		

	}
}
