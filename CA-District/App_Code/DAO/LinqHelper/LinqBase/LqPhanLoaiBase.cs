




/*
'===============================================================================
'  LinqHelper.DAO.PhanLoaiBase
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
	public class LqPhanLoaiBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqPhanLoaiBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqPhanLoaiEntity obj)
		{
			provider.GetTable<LqPhanLoaiEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqPhanLoaiEntity _obj)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqPhanLoaiEntity tmp = q.First<LqPhanLoaiEntity>();
			
			tmp.TenPhanLoai = _obj.TenPhanLoai;
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
		
		public void Delete(LqPhanLoaiEntity obj)
		{
			provider.GetTable<LqPhanLoaiEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqPhanLoaiEntity ob = (LqPhanLoaiEntity)q.First<LqPhanLoaiEntity>();
            provider.GetTable<LqPhanLoaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenPhanLoai(string TenPhanLoai)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiEntity>()
                    where obj.TenPhanLoai == TenPhanLoai
                    select obj;
					
            LqPhanLoaiEntity ob = (LqPhanLoaiEntity)q.First<LqPhanLoaiEntity>();
            provider.GetTable<LqPhanLoaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqPhanLoaiEntity ob = (LqPhanLoaiEntity)q.First<LqPhanLoaiEntity>();
            provider.GetTable<LqPhanLoaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqPhanLoaiEntity ob = (LqPhanLoaiEntity)q.First<LqPhanLoaiEntity>();
            provider.GetTable<LqPhanLoaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqPhanLoaiEntity ob = (LqPhanLoaiEntity)q.First<LqPhanLoaiEntity>();
            provider.GetTable<LqPhanLoaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqPhanLoaiEntity ob = (LqPhanLoaiEntity)q.First<LqPhanLoaiEntity>();
            provider.GetTable<LqPhanLoaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqPhanLoaiEntity ob = (LqPhanLoaiEntity)q.First<LqPhanLoaiEntity>();
            provider.GetTable<LqPhanLoaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqPhanLoaiEntity ob = (LqPhanLoaiEntity)q.First<LqPhanLoaiEntity>();
            provider.GetTable<LqPhanLoaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqPhanLoaiEntity ob = (LqPhanLoaiEntity)q.First<LqPhanLoaiEntity>();
            provider.GetTable<LqPhanLoaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqPhanLoaiEntity ob = (LqPhanLoaiEntity)q.First<LqPhanLoaiEntity>();
            provider.GetTable<LqPhanLoaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqPhanLoaiEntity ob = (LqPhanLoaiEntity)q.First<LqPhanLoaiEntity>();
            provider.GetTable<LqPhanLoaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqPhanLoaiEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqPhanLoaiEntity>();
		}

		public List<LqPhanLoaiEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqPhanLoaiEntity>()
                        select obj;
            return query.ToList<LqPhanLoaiEntity>();
		}
		
		
		public List<LqPhanLoaiEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqPhanLoaiEntity>();
		}
		
		
		public List<LqPhanLoaiEntity> SelectByTenPhanLoai(string TenPhanLoai)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiEntity>()
                        where obj.TenPhanLoai == TenPhanLoai
                        select obj;
            return query.ToList<LqPhanLoaiEntity>();
		}
		
		
		public List<LqPhanLoaiEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqPhanLoaiEntity>();
		}
		
		
		public List<LqPhanLoaiEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqPhanLoaiEntity>();
		}
		
		
		public List<LqPhanLoaiEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqPhanLoaiEntity>();
		}
		
		
		public List<LqPhanLoaiEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqPhanLoaiEntity>();
		}
		
		
		public List<LqPhanLoaiEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqPhanLoaiEntity>();
		}
		
		
		public List<LqPhanLoaiEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqPhanLoaiEntity>();
		}
		
		
		public List<LqPhanLoaiEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqPhanLoaiEntity>();
		}
		
		
		public List<LqPhanLoaiEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqPhanLoaiEntity>();
		}
		
		
		public List<LqPhanLoaiEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqPhanLoaiEntity>();
		}
		
		
		

	}
}
