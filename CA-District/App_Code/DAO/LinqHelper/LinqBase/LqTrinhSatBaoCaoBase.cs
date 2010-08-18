




/*
'===============================================================================
'  LinqHelper.DAO.TrinhSatBaoCaoBase
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
	public class LqTrinhSatBaoCaoBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTrinhSatBaoCaoBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqTrinhSatBaoCaoEntity obj)
		{
			provider.GetTable<LqTrinhSatBaoCaoEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqTrinhSatBaoCaoEntity _obj)
		{
			var q = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqTrinhSatBaoCaoEntity tmp = q.First<LqTrinhSatBaoCaoEntity>();
			
			tmp.TenTrinhSatBaoCao = _obj.TenTrinhSatBaoCao;
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
		
		public void Delete(LqTrinhSatBaoCaoEntity obj)
		{
			provider.GetTable<LqTrinhSatBaoCaoEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqTrinhSatBaoCaoEntity ob = (LqTrinhSatBaoCaoEntity)q.First<LqTrinhSatBaoCaoEntity>();
            provider.GetTable<LqTrinhSatBaoCaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenTrinhSatBaoCao(string TenTrinhSatBaoCao)
		{
			var q = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                    where obj.TenTrinhSatBaoCao == TenTrinhSatBaoCao
                    select obj;
					
            LqTrinhSatBaoCaoEntity ob = (LqTrinhSatBaoCaoEntity)q.First<LqTrinhSatBaoCaoEntity>();
            provider.GetTable<LqTrinhSatBaoCaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqTrinhSatBaoCaoEntity ob = (LqTrinhSatBaoCaoEntity)q.First<LqTrinhSatBaoCaoEntity>();
            provider.GetTable<LqTrinhSatBaoCaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqTrinhSatBaoCaoEntity ob = (LqTrinhSatBaoCaoEntity)q.First<LqTrinhSatBaoCaoEntity>();
            provider.GetTable<LqTrinhSatBaoCaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqTrinhSatBaoCaoEntity ob = (LqTrinhSatBaoCaoEntity)q.First<LqTrinhSatBaoCaoEntity>();
            provider.GetTable<LqTrinhSatBaoCaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqTrinhSatBaoCaoEntity ob = (LqTrinhSatBaoCaoEntity)q.First<LqTrinhSatBaoCaoEntity>();
            provider.GetTable<LqTrinhSatBaoCaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqTrinhSatBaoCaoEntity ob = (LqTrinhSatBaoCaoEntity)q.First<LqTrinhSatBaoCaoEntity>();
            provider.GetTable<LqTrinhSatBaoCaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqTrinhSatBaoCaoEntity ob = (LqTrinhSatBaoCaoEntity)q.First<LqTrinhSatBaoCaoEntity>();
            provider.GetTable<LqTrinhSatBaoCaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqTrinhSatBaoCaoEntity ob = (LqTrinhSatBaoCaoEntity)q.First<LqTrinhSatBaoCaoEntity>();
            provider.GetTable<LqTrinhSatBaoCaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqTrinhSatBaoCaoEntity ob = (LqTrinhSatBaoCaoEntity)q.First<LqTrinhSatBaoCaoEntity>();
            provider.GetTable<LqTrinhSatBaoCaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqTrinhSatBaoCaoEntity ob = (LqTrinhSatBaoCaoEntity)q.First<LqTrinhSatBaoCaoEntity>();
            provider.GetTable<LqTrinhSatBaoCaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqTrinhSatBaoCaoEntity ob = (LqTrinhSatBaoCaoEntity)q.First<LqTrinhSatBaoCaoEntity>();
            provider.GetTable<LqTrinhSatBaoCaoEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqTrinhSatBaoCaoEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqTrinhSatBaoCaoEntity>();
		}

		public List<LqTrinhSatBaoCaoEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                        select obj;
            return query.ToList<LqTrinhSatBaoCaoEntity>();
		}
		
		
		public List<LqTrinhSatBaoCaoEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqTrinhSatBaoCaoEntity>();
		}
		
		
		public List<LqTrinhSatBaoCaoEntity> SelectByTenTrinhSatBaoCao(string TenTrinhSatBaoCao)
		{
			var query = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                        where obj.TenTrinhSatBaoCao == TenTrinhSatBaoCao
                        select obj;
            return query.ToList<LqTrinhSatBaoCaoEntity>();
		}
		
		
		public List<LqTrinhSatBaoCaoEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqTrinhSatBaoCaoEntity>();
		}
		
		
		public List<LqTrinhSatBaoCaoEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqTrinhSatBaoCaoEntity>();
		}
		
		
		public List<LqTrinhSatBaoCaoEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqTrinhSatBaoCaoEntity>();
		}
		
		
		public List<LqTrinhSatBaoCaoEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqTrinhSatBaoCaoEntity>();
		}
		
		
		public List<LqTrinhSatBaoCaoEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqTrinhSatBaoCaoEntity>();
		}
		
		
		public List<LqTrinhSatBaoCaoEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqTrinhSatBaoCaoEntity>();
		}
		
		
		public List<LqTrinhSatBaoCaoEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqTrinhSatBaoCaoEntity>();
		}
		
		
		public List<LqTrinhSatBaoCaoEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqTrinhSatBaoCaoEntity>();
		}
		
		
		public List<LqTrinhSatBaoCaoEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqTrinhSatBaoCaoEntity>();
		}
		
		
		public List<LqTrinhSatBaoCaoEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqTrinhSatBaoCaoEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqTrinhSatBaoCaoEntity>();
		}
		
		
		

	}
}
