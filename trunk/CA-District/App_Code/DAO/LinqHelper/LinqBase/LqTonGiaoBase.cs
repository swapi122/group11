




/*
'===============================================================================
'  LinqHelper.DAO.TonGiaoBase
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
	public class LqTonGiaoBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTonGiaoBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqTonGiaoEntity obj)
		{
			provider.GetTable<LqTonGiaoEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqTonGiaoEntity _obj)
		{
			var q = from obj in provider.GetTable<LqTonGiaoEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqTonGiaoEntity tmp = q.First<LqTonGiaoEntity>();
			
			tmp.TenTonGiao = _obj.TenTonGiao;
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
		
		public void Delete(LqTonGiaoEntity obj)
		{
			provider.GetTable<LqTonGiaoEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqTonGiaoEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqTonGiaoEntity ob = (LqTonGiaoEntity)q.First<LqTonGiaoEntity>();
            provider.GetTable<LqTonGiaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenTonGiao(string TenTonGiao)
		{
			var q = from obj in provider.GetTable<LqTonGiaoEntity>()
                    where obj.TenTonGiao == TenTonGiao
                    select obj;
					
            LqTonGiaoEntity ob = (LqTonGiaoEntity)q.First<LqTonGiaoEntity>();
            provider.GetTable<LqTonGiaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqTonGiaoEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqTonGiaoEntity ob = (LqTonGiaoEntity)q.First<LqTonGiaoEntity>();
            provider.GetTable<LqTonGiaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqTonGiaoEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqTonGiaoEntity ob = (LqTonGiaoEntity)q.First<LqTonGiaoEntity>();
            provider.GetTable<LqTonGiaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqTonGiaoEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqTonGiaoEntity ob = (LqTonGiaoEntity)q.First<LqTonGiaoEntity>();
            provider.GetTable<LqTonGiaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqTonGiaoEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqTonGiaoEntity ob = (LqTonGiaoEntity)q.First<LqTonGiaoEntity>();
            provider.GetTable<LqTonGiaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqTonGiaoEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqTonGiaoEntity ob = (LqTonGiaoEntity)q.First<LqTonGiaoEntity>();
            provider.GetTable<LqTonGiaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqTonGiaoEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqTonGiaoEntity ob = (LqTonGiaoEntity)q.First<LqTonGiaoEntity>();
            provider.GetTable<LqTonGiaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqTonGiaoEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqTonGiaoEntity ob = (LqTonGiaoEntity)q.First<LqTonGiaoEntity>();
            provider.GetTable<LqTonGiaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqTonGiaoEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqTonGiaoEntity ob = (LqTonGiaoEntity)q.First<LqTonGiaoEntity>();
            provider.GetTable<LqTonGiaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqTonGiaoEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqTonGiaoEntity ob = (LqTonGiaoEntity)q.First<LqTonGiaoEntity>();
            provider.GetTable<LqTonGiaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqTonGiaoEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqTonGiaoEntity ob = (LqTonGiaoEntity)q.First<LqTonGiaoEntity>();
            provider.GetTable<LqTonGiaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqTonGiaoEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTonGiaoEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqTonGiaoEntity>();
		}

		public List<LqTonGiaoEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqTonGiaoEntity>()
                        select obj;
            return query.ToList<LqTonGiaoEntity>();
		}
		
		
		public List<LqTonGiaoEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTonGiaoEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqTonGiaoEntity>();
		}
		
		
		public List<LqTonGiaoEntity> SelectByTenTonGiao(string TenTonGiao)
		{
			var query = from obj in provider.GetTable<LqTonGiaoEntity>()
                        where obj.TenTonGiao == TenTonGiao
                        select obj;
            return query.ToList<LqTonGiaoEntity>();
		}
		
		
		public List<LqTonGiaoEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqTonGiaoEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqTonGiaoEntity>();
		}
		
		
		public List<LqTonGiaoEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqTonGiaoEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqTonGiaoEntity>();
		}
		
		
		public List<LqTonGiaoEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqTonGiaoEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqTonGiaoEntity>();
		}
		
		
		public List<LqTonGiaoEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqTonGiaoEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqTonGiaoEntity>();
		}
		
		
		public List<LqTonGiaoEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqTonGiaoEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqTonGiaoEntity>();
		}
		
		
		public List<LqTonGiaoEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqTonGiaoEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqTonGiaoEntity>();
		}
		
		
		public List<LqTonGiaoEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqTonGiaoEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqTonGiaoEntity>();
		}
		
		
		public List<LqTonGiaoEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqTonGiaoEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqTonGiaoEntity>();
		}
		
		
		public List<LqTonGiaoEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqTonGiaoEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqTonGiaoEntity>();
		}
		
		
		public List<LqTonGiaoEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqTonGiaoEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqTonGiaoEntity>();
		}
		
		
		

	}
}
