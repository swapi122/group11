




/*
'===============================================================================
'  LinqHelper.DAO.TangVatBase
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
	public class LqTangVatBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTangVatBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqTangVatEntity obj)
		{
			provider.GetTable<LqTangVatEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqTangVatEntity _obj)
		{
			var q = from obj in provider.GetTable<LqTangVatEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqTangVatEntity tmp = q.First<LqTangVatEntity>();
			
			tmp.TenTangVat = _obj.TenTangVat;
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
		
		public void Delete(LqTangVatEntity obj)
		{
			provider.GetTable<LqTangVatEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqTangVatEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqTangVatEntity ob = (LqTangVatEntity)q.First<LqTangVatEntity>();
            provider.GetTable<LqTangVatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenTangVat(string TenTangVat)
		{
			var q = from obj in provider.GetTable<LqTangVatEntity>()
                    where obj.TenTangVat == TenTangVat
                    select obj;
					
            LqTangVatEntity ob = (LqTangVatEntity)q.First<LqTangVatEntity>();
            provider.GetTable<LqTangVatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqTangVatEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqTangVatEntity ob = (LqTangVatEntity)q.First<LqTangVatEntity>();
            provider.GetTable<LqTangVatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqTangVatEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqTangVatEntity ob = (LqTangVatEntity)q.First<LqTangVatEntity>();
            provider.GetTable<LqTangVatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqTangVatEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqTangVatEntity ob = (LqTangVatEntity)q.First<LqTangVatEntity>();
            provider.GetTable<LqTangVatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqTangVatEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqTangVatEntity ob = (LqTangVatEntity)q.First<LqTangVatEntity>();
            provider.GetTable<LqTangVatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqTangVatEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqTangVatEntity ob = (LqTangVatEntity)q.First<LqTangVatEntity>();
            provider.GetTable<LqTangVatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqTangVatEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqTangVatEntity ob = (LqTangVatEntity)q.First<LqTangVatEntity>();
            provider.GetTable<LqTangVatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqTangVatEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqTangVatEntity ob = (LqTangVatEntity)q.First<LqTangVatEntity>();
            provider.GetTable<LqTangVatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqTangVatEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqTangVatEntity ob = (LqTangVatEntity)q.First<LqTangVatEntity>();
            provider.GetTable<LqTangVatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqTangVatEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqTangVatEntity ob = (LqTangVatEntity)q.First<LqTangVatEntity>();
            provider.GetTable<LqTangVatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqTangVatEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqTangVatEntity ob = (LqTangVatEntity)q.First<LqTangVatEntity>();
            provider.GetTable<LqTangVatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqTangVatEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTangVatEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqTangVatEntity>();
		}

		public List<LqTangVatEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqTangVatEntity>()
                        select obj;
            return query.ToList<LqTangVatEntity>();
		}
		
		
		public List<LqTangVatEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTangVatEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqTangVatEntity>();
		}
		
		
		public List<LqTangVatEntity> SelectByTenTangVat(string TenTangVat)
		{
			var query = from obj in provider.GetTable<LqTangVatEntity>()
                        where obj.TenTangVat == TenTangVat
                        select obj;
            return query.ToList<LqTangVatEntity>();
		}
		
		
		public List<LqTangVatEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqTangVatEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqTangVatEntity>();
		}
		
		
		public List<LqTangVatEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqTangVatEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqTangVatEntity>();
		}
		
		
		public List<LqTangVatEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqTangVatEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqTangVatEntity>();
		}
		
		
		public List<LqTangVatEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqTangVatEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqTangVatEntity>();
		}
		
		
		public List<LqTangVatEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqTangVatEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqTangVatEntity>();
		}
		
		
		public List<LqTangVatEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqTangVatEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqTangVatEntity>();
		}
		
		
		public List<LqTangVatEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqTangVatEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqTangVatEntity>();
		}
		
		
		public List<LqTangVatEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqTangVatEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqTangVatEntity>();
		}
		
		
		public List<LqTangVatEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqTangVatEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqTangVatEntity>();
		}
		
		
		public List<LqTangVatEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqTangVatEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqTangVatEntity>();
		}
		
		
		

	}
}
