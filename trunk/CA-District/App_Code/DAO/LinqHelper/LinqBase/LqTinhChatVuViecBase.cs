




/*
'===============================================================================
'  LinqHelper.DAO.TinhChatVuViecBase
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
	public class LqTinhChatVuViecBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTinhChatVuViecBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqTinhChatVuViecEntity obj)
		{
			provider.GetTable<LqTinhChatVuViecEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqTinhChatVuViecEntity _obj)
		{
			var q = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqTinhChatVuViecEntity tmp = q.First<LqTinhChatVuViecEntity>();
			
			tmp.TenTinhChatVuViec = _obj.TenTinhChatVuViec;
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
		
		public void Delete(LqTinhChatVuViecEntity obj)
		{
			provider.GetTable<LqTinhChatVuViecEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqTinhChatVuViecEntity ob = (LqTinhChatVuViecEntity)q.First<LqTinhChatVuViecEntity>();
            provider.GetTable<LqTinhChatVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenTinhChatVuViec(string TenTinhChatVuViec)
		{
			var q = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                    where obj.TenTinhChatVuViec == TenTinhChatVuViec
                    select obj;
					
            LqTinhChatVuViecEntity ob = (LqTinhChatVuViecEntity)q.First<LqTinhChatVuViecEntity>();
            provider.GetTable<LqTinhChatVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqTinhChatVuViecEntity ob = (LqTinhChatVuViecEntity)q.First<LqTinhChatVuViecEntity>();
            provider.GetTable<LqTinhChatVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqTinhChatVuViecEntity ob = (LqTinhChatVuViecEntity)q.First<LqTinhChatVuViecEntity>();
            provider.GetTable<LqTinhChatVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqTinhChatVuViecEntity ob = (LqTinhChatVuViecEntity)q.First<LqTinhChatVuViecEntity>();
            provider.GetTable<LqTinhChatVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqTinhChatVuViecEntity ob = (LqTinhChatVuViecEntity)q.First<LqTinhChatVuViecEntity>();
            provider.GetTable<LqTinhChatVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqTinhChatVuViecEntity ob = (LqTinhChatVuViecEntity)q.First<LqTinhChatVuViecEntity>();
            provider.GetTable<LqTinhChatVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqTinhChatVuViecEntity ob = (LqTinhChatVuViecEntity)q.First<LqTinhChatVuViecEntity>();
            provider.GetTable<LqTinhChatVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqTinhChatVuViecEntity ob = (LqTinhChatVuViecEntity)q.First<LqTinhChatVuViecEntity>();
            provider.GetTable<LqTinhChatVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqTinhChatVuViecEntity ob = (LqTinhChatVuViecEntity)q.First<LqTinhChatVuViecEntity>();
            provider.GetTable<LqTinhChatVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqTinhChatVuViecEntity ob = (LqTinhChatVuViecEntity)q.First<LqTinhChatVuViecEntity>();
            provider.GetTable<LqTinhChatVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqTinhChatVuViecEntity ob = (LqTinhChatVuViecEntity)q.First<LqTinhChatVuViecEntity>();
            provider.GetTable<LqTinhChatVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqTinhChatVuViecEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqTinhChatVuViecEntity>();
		}

		public List<LqTinhChatVuViecEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                        select obj;
            return query.ToList<LqTinhChatVuViecEntity>();
		}
		
		
		public List<LqTinhChatVuViecEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqTinhChatVuViecEntity>();
		}
		
		
		public List<LqTinhChatVuViecEntity> SelectByTenTinhChatVuViec(string TenTinhChatVuViec)
		{
			var query = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                        where obj.TenTinhChatVuViec == TenTinhChatVuViec
                        select obj;
            return query.ToList<LqTinhChatVuViecEntity>();
		}
		
		
		public List<LqTinhChatVuViecEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqTinhChatVuViecEntity>();
		}
		
		
		public List<LqTinhChatVuViecEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqTinhChatVuViecEntity>();
		}
		
		
		public List<LqTinhChatVuViecEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqTinhChatVuViecEntity>();
		}
		
		
		public List<LqTinhChatVuViecEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqTinhChatVuViecEntity>();
		}
		
		
		public List<LqTinhChatVuViecEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqTinhChatVuViecEntity>();
		}
		
		
		public List<LqTinhChatVuViecEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqTinhChatVuViecEntity>();
		}
		
		
		public List<LqTinhChatVuViecEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqTinhChatVuViecEntity>();
		}
		
		
		public List<LqTinhChatVuViecEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqTinhChatVuViecEntity>();
		}
		
		
		public List<LqTinhChatVuViecEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqTinhChatVuViecEntity>();
		}
		
		
		public List<LqTinhChatVuViecEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqTinhChatVuViecEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqTinhChatVuViecEntity>();
		}
		
		
		

	}
}
