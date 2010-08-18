




/*
'===============================================================================
'  LinqHelper.DAO.LoaiTapTinBase
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
	public class LqLoaiTapTinBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqLoaiTapTinBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqLoaiTapTinEntity obj)
		{
			provider.GetTable<LqLoaiTapTinEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqLoaiTapTinEntity _obj)
		{
			var q = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqLoaiTapTinEntity tmp = q.First<LqLoaiTapTinEntity>();
			
			tmp.TenLoaiTapTin = _obj.TenLoaiTapTin;
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
		
		public void Delete(LqLoaiTapTinEntity obj)
		{
			provider.GetTable<LqLoaiTapTinEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqLoaiTapTinEntity ob = (LqLoaiTapTinEntity)q.First<LqLoaiTapTinEntity>();
            provider.GetTable<LqLoaiTapTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenLoaiTapTin(string TenLoaiTapTin)
		{
			var q = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                    where obj.TenLoaiTapTin == TenLoaiTapTin
                    select obj;
					
            LqLoaiTapTinEntity ob = (LqLoaiTapTinEntity)q.First<LqLoaiTapTinEntity>();
            provider.GetTable<LqLoaiTapTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqLoaiTapTinEntity ob = (LqLoaiTapTinEntity)q.First<LqLoaiTapTinEntity>();
            provider.GetTable<LqLoaiTapTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqLoaiTapTinEntity ob = (LqLoaiTapTinEntity)q.First<LqLoaiTapTinEntity>();
            provider.GetTable<LqLoaiTapTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqLoaiTapTinEntity ob = (LqLoaiTapTinEntity)q.First<LqLoaiTapTinEntity>();
            provider.GetTable<LqLoaiTapTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqLoaiTapTinEntity ob = (LqLoaiTapTinEntity)q.First<LqLoaiTapTinEntity>();
            provider.GetTable<LqLoaiTapTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqLoaiTapTinEntity ob = (LqLoaiTapTinEntity)q.First<LqLoaiTapTinEntity>();
            provider.GetTable<LqLoaiTapTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqLoaiTapTinEntity ob = (LqLoaiTapTinEntity)q.First<LqLoaiTapTinEntity>();
            provider.GetTable<LqLoaiTapTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqLoaiTapTinEntity ob = (LqLoaiTapTinEntity)q.First<LqLoaiTapTinEntity>();
            provider.GetTable<LqLoaiTapTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqLoaiTapTinEntity ob = (LqLoaiTapTinEntity)q.First<LqLoaiTapTinEntity>();
            provider.GetTable<LqLoaiTapTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqLoaiTapTinEntity ob = (LqLoaiTapTinEntity)q.First<LqLoaiTapTinEntity>();
            provider.GetTable<LqLoaiTapTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqLoaiTapTinEntity ob = (LqLoaiTapTinEntity)q.First<LqLoaiTapTinEntity>();
            provider.GetTable<LqLoaiTapTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqLoaiTapTinEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqLoaiTapTinEntity>();
		}

		public List<LqLoaiTapTinEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                        select obj;
            return query.ToList<LqLoaiTapTinEntity>();
		}
		
		
		public List<LqLoaiTapTinEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqLoaiTapTinEntity>();
		}
		
		
		public List<LqLoaiTapTinEntity> SelectByTenLoaiTapTin(string TenLoaiTapTin)
		{
			var query = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                        where obj.TenLoaiTapTin == TenLoaiTapTin
                        select obj;
            return query.ToList<LqLoaiTapTinEntity>();
		}
		
		
		public List<LqLoaiTapTinEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqLoaiTapTinEntity>();
		}
		
		
		public List<LqLoaiTapTinEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqLoaiTapTinEntity>();
		}
		
		
		public List<LqLoaiTapTinEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqLoaiTapTinEntity>();
		}
		
		
		public List<LqLoaiTapTinEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqLoaiTapTinEntity>();
		}
		
		
		public List<LqLoaiTapTinEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqLoaiTapTinEntity>();
		}
		
		
		public List<LqLoaiTapTinEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqLoaiTapTinEntity>();
		}
		
		
		public List<LqLoaiTapTinEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqLoaiTapTinEntity>();
		}
		
		
		public List<LqLoaiTapTinEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqLoaiTapTinEntity>();
		}
		
		
		public List<LqLoaiTapTinEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqLoaiTapTinEntity>();
		}
		
		
		public List<LqLoaiTapTinEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqLoaiTapTinEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqLoaiTapTinEntity>();
		}
		
		
		

	}
}
