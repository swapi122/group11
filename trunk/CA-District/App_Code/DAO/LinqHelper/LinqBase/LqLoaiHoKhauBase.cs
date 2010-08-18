




/*
'===============================================================================
'  LinqHelper.DAO.LoaiHoKhauBase
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
	public class LqLoaiHoKhauBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqLoaiHoKhauBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqLoaiHoKhauEntity obj)
		{
			provider.GetTable<LqLoaiHoKhauEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqLoaiHoKhauEntity _obj)
		{
			var q = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqLoaiHoKhauEntity tmp = q.First<LqLoaiHoKhauEntity>();
			
			tmp.TenLoaiHoKhau = _obj.TenLoaiHoKhau;
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
		
		public void Delete(LqLoaiHoKhauEntity obj)
		{
			provider.GetTable<LqLoaiHoKhauEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqLoaiHoKhauEntity ob = (LqLoaiHoKhauEntity)q.First<LqLoaiHoKhauEntity>();
            provider.GetTable<LqLoaiHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenLoaiHoKhau(string TenLoaiHoKhau)
		{
			var q = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                    where obj.TenLoaiHoKhau == TenLoaiHoKhau
                    select obj;
					
            LqLoaiHoKhauEntity ob = (LqLoaiHoKhauEntity)q.First<LqLoaiHoKhauEntity>();
            provider.GetTable<LqLoaiHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqLoaiHoKhauEntity ob = (LqLoaiHoKhauEntity)q.First<LqLoaiHoKhauEntity>();
            provider.GetTable<LqLoaiHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqLoaiHoKhauEntity ob = (LqLoaiHoKhauEntity)q.First<LqLoaiHoKhauEntity>();
            provider.GetTable<LqLoaiHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqLoaiHoKhauEntity ob = (LqLoaiHoKhauEntity)q.First<LqLoaiHoKhauEntity>();
            provider.GetTable<LqLoaiHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqLoaiHoKhauEntity ob = (LqLoaiHoKhauEntity)q.First<LqLoaiHoKhauEntity>();
            provider.GetTable<LqLoaiHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqLoaiHoKhauEntity ob = (LqLoaiHoKhauEntity)q.First<LqLoaiHoKhauEntity>();
            provider.GetTable<LqLoaiHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqLoaiHoKhauEntity ob = (LqLoaiHoKhauEntity)q.First<LqLoaiHoKhauEntity>();
            provider.GetTable<LqLoaiHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqLoaiHoKhauEntity ob = (LqLoaiHoKhauEntity)q.First<LqLoaiHoKhauEntity>();
            provider.GetTable<LqLoaiHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqLoaiHoKhauEntity ob = (LqLoaiHoKhauEntity)q.First<LqLoaiHoKhauEntity>();
            provider.GetTable<LqLoaiHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqLoaiHoKhauEntity ob = (LqLoaiHoKhauEntity)q.First<LqLoaiHoKhauEntity>();
            provider.GetTable<LqLoaiHoKhauEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqLoaiHoKhauEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqLoaiHoKhauEntity>();
		}

		public List<LqLoaiHoKhauEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                        select obj;
            return query.ToList<LqLoaiHoKhauEntity>();
		}
		
		
		public List<LqLoaiHoKhauEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqLoaiHoKhauEntity>();
		}
		
		
		public List<LqLoaiHoKhauEntity> SelectByTenLoaiHoKhau(string TenLoaiHoKhau)
		{
			var query = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                        where obj.TenLoaiHoKhau == TenLoaiHoKhau
                        select obj;
            return query.ToList<LqLoaiHoKhauEntity>();
		}
		
		
		public List<LqLoaiHoKhauEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqLoaiHoKhauEntity>();
		}
		
		
		public List<LqLoaiHoKhauEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqLoaiHoKhauEntity>();
		}
		
		
		public List<LqLoaiHoKhauEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqLoaiHoKhauEntity>();
		}
		
		
		public List<LqLoaiHoKhauEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqLoaiHoKhauEntity>();
		}
		
		
		public List<LqLoaiHoKhauEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqLoaiHoKhauEntity>();
		}
		
		
		public List<LqLoaiHoKhauEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqLoaiHoKhauEntity>();
		}
		
		
		public List<LqLoaiHoKhauEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqLoaiHoKhauEntity>();
		}
		
		
		public List<LqLoaiHoKhauEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqLoaiHoKhauEntity>();
		}
		
		
		public List<LqLoaiHoKhauEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqLoaiHoKhauEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqLoaiHoKhauEntity>();
		}
		
		
		

	}
}
