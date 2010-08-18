




/*
'===============================================================================
'  LinqHelper.DAO.XuLyDoiTuongBase
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
	public class LqXuLyDoiTuongBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqXuLyDoiTuongBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqXuLyDoiTuongEntity obj)
		{
			provider.GetTable<LqXuLyDoiTuongEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqXuLyDoiTuongEntity _obj)
		{
			var q = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqXuLyDoiTuongEntity tmp = q.First<LqXuLyDoiTuongEntity>();
			
			tmp.TenXuLyDoiTuong = _obj.TenXuLyDoiTuong;
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
		
		public void Delete(LqXuLyDoiTuongEntity obj)
		{
			provider.GetTable<LqXuLyDoiTuongEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqXuLyDoiTuongEntity ob = (LqXuLyDoiTuongEntity)q.First<LqXuLyDoiTuongEntity>();
            provider.GetTable<LqXuLyDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenXuLyDoiTuong(string TenXuLyDoiTuong)
		{
			var q = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                    where obj.TenXuLyDoiTuong == TenXuLyDoiTuong
                    select obj;
					
            LqXuLyDoiTuongEntity ob = (LqXuLyDoiTuongEntity)q.First<LqXuLyDoiTuongEntity>();
            provider.GetTable<LqXuLyDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqXuLyDoiTuongEntity ob = (LqXuLyDoiTuongEntity)q.First<LqXuLyDoiTuongEntity>();
            provider.GetTable<LqXuLyDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqXuLyDoiTuongEntity ob = (LqXuLyDoiTuongEntity)q.First<LqXuLyDoiTuongEntity>();
            provider.GetTable<LqXuLyDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqXuLyDoiTuongEntity ob = (LqXuLyDoiTuongEntity)q.First<LqXuLyDoiTuongEntity>();
            provider.GetTable<LqXuLyDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqXuLyDoiTuongEntity ob = (LqXuLyDoiTuongEntity)q.First<LqXuLyDoiTuongEntity>();
            provider.GetTable<LqXuLyDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqXuLyDoiTuongEntity ob = (LqXuLyDoiTuongEntity)q.First<LqXuLyDoiTuongEntity>();
            provider.GetTable<LqXuLyDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqXuLyDoiTuongEntity ob = (LqXuLyDoiTuongEntity)q.First<LqXuLyDoiTuongEntity>();
            provider.GetTable<LqXuLyDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqXuLyDoiTuongEntity ob = (LqXuLyDoiTuongEntity)q.First<LqXuLyDoiTuongEntity>();
            provider.GetTable<LqXuLyDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqXuLyDoiTuongEntity ob = (LqXuLyDoiTuongEntity)q.First<LqXuLyDoiTuongEntity>();
            provider.GetTable<LqXuLyDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqXuLyDoiTuongEntity ob = (LqXuLyDoiTuongEntity)q.First<LqXuLyDoiTuongEntity>();
            provider.GetTable<LqXuLyDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                    where obj.TrangThai.Value == TrangThai
                    select obj;
					
            LqXuLyDoiTuongEntity ob = (LqXuLyDoiTuongEntity)q.First<LqXuLyDoiTuongEntity>();
            provider.GetTable<LqXuLyDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqXuLyDoiTuongEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqXuLyDoiTuongEntity>();
		}

		public List<LqXuLyDoiTuongEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                        select obj;
            return query.ToList<LqXuLyDoiTuongEntity>();
		}
		
		
		public List<LqXuLyDoiTuongEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqXuLyDoiTuongEntity>();
		}
		
		
		public List<LqXuLyDoiTuongEntity> SelectByTenXuLyDoiTuong(string TenXuLyDoiTuong)
		{
			var query = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                        where obj.TenXuLyDoiTuong == TenXuLyDoiTuong
                        select obj;
            return query.ToList<LqXuLyDoiTuongEntity>();
		}
		
		
		public List<LqXuLyDoiTuongEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqXuLyDoiTuongEntity>();
		}
		
		
		public List<LqXuLyDoiTuongEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqXuLyDoiTuongEntity>();
		}
		
		
		public List<LqXuLyDoiTuongEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqXuLyDoiTuongEntity>();
		}
		
		
		public List<LqXuLyDoiTuongEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqXuLyDoiTuongEntity>();
		}
		
		
		public List<LqXuLyDoiTuongEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqXuLyDoiTuongEntity>();
		}
		
		
		public List<LqXuLyDoiTuongEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqXuLyDoiTuongEntity>();
		}
		
		
		public List<LqXuLyDoiTuongEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqXuLyDoiTuongEntity>();
		}
		
		
		public List<LqXuLyDoiTuongEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqXuLyDoiTuongEntity>();
		}
		
		
		public List<LqXuLyDoiTuongEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqXuLyDoiTuongEntity>();
		}
		
		
		public List<LqXuLyDoiTuongEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqXuLyDoiTuongEntity>()
                        where obj.TrangThai.Value == TrangThai
                        select obj;
            return query.ToList<LqXuLyDoiTuongEntity>();
		}
		
		
		

	}
}
