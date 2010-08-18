




/*
'===============================================================================
'  LinqHelper.DAO.ChucSacBase
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
	public class LqChucSacBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqChucSacBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqChucSacEntity obj)
		{
			provider.GetTable<LqChucSacEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqChucSacEntity _obj)
		{
			var q = from obj in provider.GetTable<LqChucSacEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqChucSacEntity tmp = q.First<LqChucSacEntity>();
			
			tmp.TenChucSac = _obj.TenChucSac;
			tmp.IdTonGiao = _obj.IdTonGiao;
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
		
		public void Delete(LqChucSacEntity obj)
		{
			provider.GetTable<LqChucSacEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqChucSacEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqChucSacEntity ob = (LqChucSacEntity)q.First<LqChucSacEntity>();
            provider.GetTable<LqChucSacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenChucSac(string TenChucSac)
		{
			var q = from obj in provider.GetTable<LqChucSacEntity>()
                    where obj.TenChucSac == TenChucSac
                    select obj;
					
            LqChucSacEntity ob = (LqChucSacEntity)q.First<LqChucSacEntity>();
            provider.GetTable<LqChucSacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdTonGiao(Guid IdTonGiao)
		{
			var q = from obj in provider.GetTable<LqChucSacEntity>()
                    where obj.IdTonGiao.Value == IdTonGiao
                    select obj;
					
            LqChucSacEntity ob = (LqChucSacEntity)q.First<LqChucSacEntity>();
            provider.GetTable<LqChucSacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqChucSacEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqChucSacEntity ob = (LqChucSacEntity)q.First<LqChucSacEntity>();
            provider.GetTable<LqChucSacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqChucSacEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqChucSacEntity ob = (LqChucSacEntity)q.First<LqChucSacEntity>();
            provider.GetTable<LqChucSacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqChucSacEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqChucSacEntity ob = (LqChucSacEntity)q.First<LqChucSacEntity>();
            provider.GetTable<LqChucSacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqChucSacEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqChucSacEntity ob = (LqChucSacEntity)q.First<LqChucSacEntity>();
            provider.GetTable<LqChucSacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqChucSacEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqChucSacEntity ob = (LqChucSacEntity)q.First<LqChucSacEntity>();
            provider.GetTable<LqChucSacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqChucSacEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqChucSacEntity ob = (LqChucSacEntity)q.First<LqChucSacEntity>();
            provider.GetTable<LqChucSacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqChucSacEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqChucSacEntity ob = (LqChucSacEntity)q.First<LqChucSacEntity>();
            provider.GetTable<LqChucSacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqChucSacEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqChucSacEntity ob = (LqChucSacEntity)q.First<LqChucSacEntity>();
            provider.GetTable<LqChucSacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqChucSacEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqChucSacEntity ob = (LqChucSacEntity)q.First<LqChucSacEntity>();
            provider.GetTable<LqChucSacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqChucSacEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqChucSacEntity ob = (LqChucSacEntity)q.First<LqChucSacEntity>();
            provider.GetTable<LqChucSacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqChucSacEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqChucSacEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqChucSacEntity>();
		}

		public List<LqChucSacEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqChucSacEntity>()
                        select obj;
            return query.ToList<LqChucSacEntity>();
		}
		
		
		public List<LqChucSacEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqChucSacEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqChucSacEntity>();
		}
		
		
		public List<LqChucSacEntity> SelectByTenChucSac(string TenChucSac)
		{
			var query = from obj in provider.GetTable<LqChucSacEntity>()
                        where obj.TenChucSac == TenChucSac
                        select obj;
            return query.ToList<LqChucSacEntity>();
		}
		
		
		public List<LqChucSacEntity> SelectByIdTonGiao(Guid IdTonGiao)
		{
			var query = from obj in provider.GetTable<LqChucSacEntity>()
                        where obj.IdTonGiao.Value == IdTonGiao
                        select obj;
            return query.ToList<LqChucSacEntity>();
		}
		
		
		public List<LqChucSacEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqChucSacEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqChucSacEntity>();
		}
		
		
		public List<LqChucSacEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqChucSacEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqChucSacEntity>();
		}
		
		
		public List<LqChucSacEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqChucSacEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqChucSacEntity>();
		}
		
		
		public List<LqChucSacEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqChucSacEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqChucSacEntity>();
		}
		
		
		public List<LqChucSacEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqChucSacEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqChucSacEntity>();
		}
		
		
		public List<LqChucSacEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqChucSacEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqChucSacEntity>();
		}
		
		
		public List<LqChucSacEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqChucSacEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqChucSacEntity>();
		}
		
		
		public List<LqChucSacEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqChucSacEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqChucSacEntity>();
		}
		
		
		public List<LqChucSacEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqChucSacEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqChucSacEntity>();
		}
		
		
		public List<LqChucSacEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqChucSacEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqChucSacEntity>();
		}
		
		
		

	}
}
