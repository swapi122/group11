




/*
'===============================================================================
'  LinqHelper.DAO.LoaiDoiTuongBase
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
	public class LqLoaiDoiTuongBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqLoaiDoiTuongBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqLoaiDoiTuongEntity obj)
		{
			provider.GetTable<LqLoaiDoiTuongEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqLoaiDoiTuongEntity _obj)
		{
			var q = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqLoaiDoiTuongEntity tmp = q.First<LqLoaiDoiTuongEntity>();
			
			tmp.TenLoaiDoiTuong = _obj.TenLoaiDoiTuong;
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
		
		public void Delete(LqLoaiDoiTuongEntity obj)
		{
			provider.GetTable<LqLoaiDoiTuongEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqLoaiDoiTuongEntity ob = (LqLoaiDoiTuongEntity)q.First<LqLoaiDoiTuongEntity>();
            provider.GetTable<LqLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenLoaiDoiTuong(string TenLoaiDoiTuong)
		{
			var q = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                    where obj.TenLoaiDoiTuong == TenLoaiDoiTuong
                    select obj;
					
            LqLoaiDoiTuongEntity ob = (LqLoaiDoiTuongEntity)q.First<LqLoaiDoiTuongEntity>();
            provider.GetTable<LqLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqLoaiDoiTuongEntity ob = (LqLoaiDoiTuongEntity)q.First<LqLoaiDoiTuongEntity>();
            provider.GetTable<LqLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqLoaiDoiTuongEntity ob = (LqLoaiDoiTuongEntity)q.First<LqLoaiDoiTuongEntity>();
            provider.GetTable<LqLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqLoaiDoiTuongEntity ob = (LqLoaiDoiTuongEntity)q.First<LqLoaiDoiTuongEntity>();
            provider.GetTable<LqLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqLoaiDoiTuongEntity ob = (LqLoaiDoiTuongEntity)q.First<LqLoaiDoiTuongEntity>();
            provider.GetTable<LqLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqLoaiDoiTuongEntity ob = (LqLoaiDoiTuongEntity)q.First<LqLoaiDoiTuongEntity>();
            provider.GetTable<LqLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqLoaiDoiTuongEntity ob = (LqLoaiDoiTuongEntity)q.First<LqLoaiDoiTuongEntity>();
            provider.GetTable<LqLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqLoaiDoiTuongEntity ob = (LqLoaiDoiTuongEntity)q.First<LqLoaiDoiTuongEntity>();
            provider.GetTable<LqLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqLoaiDoiTuongEntity ob = (LqLoaiDoiTuongEntity)q.First<LqLoaiDoiTuongEntity>();
            provider.GetTable<LqLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqLoaiDoiTuongEntity ob = (LqLoaiDoiTuongEntity)q.First<LqLoaiDoiTuongEntity>();
            provider.GetTable<LqLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqLoaiDoiTuongEntity ob = (LqLoaiDoiTuongEntity)q.First<LqLoaiDoiTuongEntity>();
            provider.GetTable<LqLoaiDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqLoaiDoiTuongEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqLoaiDoiTuongEntity>();
		}

		public List<LqLoaiDoiTuongEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                        select obj;
            return query.ToList<LqLoaiDoiTuongEntity>();
		}
		
		
		public List<LqLoaiDoiTuongEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqLoaiDoiTuongEntity>();
		}
		
		
		public List<LqLoaiDoiTuongEntity> SelectByTenLoaiDoiTuong(string TenLoaiDoiTuong)
		{
			var query = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                        where obj.TenLoaiDoiTuong == TenLoaiDoiTuong
                        select obj;
            return query.ToList<LqLoaiDoiTuongEntity>();
		}
		
		
		public List<LqLoaiDoiTuongEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqLoaiDoiTuongEntity>();
		}
		
		
		public List<LqLoaiDoiTuongEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqLoaiDoiTuongEntity>();
		}
		
		
		public List<LqLoaiDoiTuongEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqLoaiDoiTuongEntity>();
		}
		
		
		public List<LqLoaiDoiTuongEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqLoaiDoiTuongEntity>();
		}
		
		
		public List<LqLoaiDoiTuongEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqLoaiDoiTuongEntity>();
		}
		
		
		public List<LqLoaiDoiTuongEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqLoaiDoiTuongEntity>();
		}
		
		
		public List<LqLoaiDoiTuongEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqLoaiDoiTuongEntity>();
		}
		
		
		public List<LqLoaiDoiTuongEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqLoaiDoiTuongEntity>();
		}
		
		
		public List<LqLoaiDoiTuongEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqLoaiDoiTuongEntity>();
		}
		
		
		public List<LqLoaiDoiTuongEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqLoaiDoiTuongEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqLoaiDoiTuongEntity>();
		}
		
		
		

	}
}
